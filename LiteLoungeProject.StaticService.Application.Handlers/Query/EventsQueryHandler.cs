using AutoMapper;
using LiteLoungeProject.StaticService.Application.Models.Query;
using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using LiteLoungeProject.StaticService.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Application.Handlers.Query
{
    public class EventsQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IEventsService _eventsService;

        public EventsQueryHandler(IMapper mapper, IEventsService eventsService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _eventsService = eventsService ?? throw new ArgumentNullException(nameof(eventsService));
        }

        public async Task<GetCurrentEventsQuery.QueryResult> HandleAsync()
        {
            var currentEventDomainModels = await _eventsService.GetCurrentEventsAsync();

            return new GetCurrentEventsQuery.QueryResult
            {
                CurrentEventModels = _mapper.Map<List<EventViewModel>>(currentEventDomainModels)
            };
        }

        public async Task<GetEventQuery.QueryResult> HandleAsync(GetEventQuery query)
        {
            var eventDomainModel = await _eventsService.GetEventAsync(query.Id);

            return new GetEventQuery.QueryResult
            {
                EventModel = _mapper.Map<EventViewModel>(eventDomainModel)
            };
        }
    }
}
