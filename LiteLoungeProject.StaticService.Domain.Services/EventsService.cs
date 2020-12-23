using AutoMapper;
using LiteLoungeProject.StaticService.Domain.Contracts;
using LiteLoungeProject.StaticService.Domain.Models;
using LiteLoungeProject.StaticService.Persistence.Contracts;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Services
{
    public class EventsService : IEventsService
    {
        private readonly IEventsRepository _eventsRepository;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;
        private readonly Contracts.Options.MemoryCacheOptions _cacheOptions;

        public EventsService(IEventsRepository eventsRepository, IMapper mapper, IMemoryCache cache, IOptions<Contracts.Options.MemoryCacheOptions> cacheOptions)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _cacheOptions = cacheOptions?.Value ?? throw new ArgumentNullException(nameof(cacheOptions));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _eventsRepository = eventsRepository ?? throw new ArgumentNullException(nameof(eventsRepository));
        }

        public async Task<List<EventModel>> GetCurrentEventsAsync()
        {
            var key = $"currentEvents";
            var eventEntities = await GetOrCreateAsync(key, ev => _eventsRepository.GetCurrentEventsAsync());
            return _mapper.Map<List<EventModel>>(eventEntities);
        }

        public async Task<EventModel> GetEventAsync(int id)
        {
            var key = $"currentEvent-{id}";
            var eventEntity = await GetOrCreateAsync(key, ev => _eventsRepository.GetEventAsync(id));
            return _mapper.Map<EventModel>(eventEntity);
        }

        private async Task<T> GetOrCreateAsync<T>(string key, Func<IEventsRepository, Task<T>> create)
        {
            return await _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.SetAbsoluteExpiration(_cacheOptions.RepositoryMamoryCacheTimeout);
                return await create(_eventsRepository);
            });
        }
    }
}
