using LiteLoungeProject.StaticService.Application.Handlers.Query;
using LiteLoungeProject.StaticService.Application.Models.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Appliation.WebApi.Controllers.Query
{
    [ApiController]
    [Route("api/query/promotions")]
    public class PromotionsQueryController : ControllerBase
    {
        private readonly ILogger<PromotionsQueryController> _logger;
        private readonly PromotionsQueryHandler _handler;

        public PromotionsQueryController(PromotionsQueryHandler handler, ILogger<PromotionsQueryController> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        [HttpGet("currentPromotions")]
        public async Task<GetCurrentPromotionsQuery.QueryResult> GetCurrentPromotionsAsync()
        {
            return await _handler.HandleAsync();
        }

        [HttpGet("promotion")]
        public async Task<GetPromotionQuery.QueryResult> GetPromotionAsync([FromQuery] GetPromotionQuery query)
        {
            return await _handler.HandleAsync(query);
        }
    }
}
