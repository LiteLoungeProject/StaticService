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
    public class PromotionsService : IPromotionsService
    {
        private readonly IPromotionsRepository _promotionsRepository;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;
        private readonly Contracts.Options.MemoryCacheOptions _cacheOptions;

        public PromotionsService(IPromotionsRepository promotionsRepository, IMapper mapper, IMemoryCache cache, IOptions<Contracts.Options.MemoryCacheOptions> cacheOptions)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _cacheOptions = cacheOptions?.Value ?? throw new ArgumentNullException(nameof(cacheOptions));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _promotionsRepository = promotionsRepository ?? throw new ArgumentNullException(nameof(promotionsRepository));
        }

        public async Task<List<PromotionModel>> GetCurrentPromotionsAsync()
        {
            var key = $"currentPromotions";
            var promotionEntities = await GetOrCreateAsync(key, pr => _promotionsRepository.GetCurrentPromotionsAsync());
            return _mapper.Map<List<PromotionModel>>(promotionEntities);
        }

        public async Task<PromotionModel> GetPromotionAsync(int id)
        {
            var key = $"currentPromotion-{id}";
            var promotionEntity = await GetOrCreateAsync(key, pr => _promotionsRepository.GetPromotionAsync(id));
            return _mapper.Map<PromotionModel>(promotionEntity);
        }

        private async Task<T> GetOrCreateAsync<T>(string key, Func<IPromotionsRepository, Task<T>> create)
        {
            return await _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.SetAbsoluteExpiration(_cacheOptions.RepositoryMamoryCacheTimeout);
                return await create(_promotionsRepository);
            });
        }
    }
}
