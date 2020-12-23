using LiteLoungeProject.StaticService.Application.Handlers.Query;
using LiteLoungeProject.StaticService.Application.Models.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Appliation.WebApi.Controllers.Query
{
    [ApiController]
    [Route("api/query/events")]
    public class EventsQueryController : ControllerBase
    {
        private readonly ILogger<EventsQueryController> _logger;
        private readonly EventsQueryHandler _handler;

        public EventsQueryController(EventsQueryHandler handler, ILogger<EventsQueryController> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        [HttpGet("currentEvents")]
        public async Task<GetCurrentEventsQuery.QueryResult> GetCurrentEventsAsync()
        {
            return await _handler.HandleAsync();
        }

        [HttpGet("event")]
        public async Task<GetEventQuery.QueryResult> GetEventAsync([FromQuery] GetEventQuery query)
        {
            return await _handler.HandleAsync(query);
        }
    }
}
