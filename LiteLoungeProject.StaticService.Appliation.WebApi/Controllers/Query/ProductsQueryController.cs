using LiteLoungeProject.StaticService.Application.Handlers.Query;
using LiteLoungeProject.StaticService.Application.Models.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Appliation.WebApi.Controllers.Query
{

    [ApiController]
    [Route("api/query/products")]
    public class ProductsQueryController : ControllerBase
    {
        private readonly ILogger<ProductsQueryController> _logger;
        private readonly ProductsQueryHandler _handler;

        public ProductsQueryController(ProductsQueryHandler handler, ILogger<ProductsQueryController> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        [HttpGet("currentProducts")]
        public async Task<GetCurrentProductsQuery.QueryResult> GetCurrentProductsAsync()
        {
            return await _handler.HandleAsync();
        }

        [HttpGet("product")]
        public async Task<GetProductQuery.QueryResult> GetProductAsync([FromQuery] GetProductQuery query)
        {
            return await _handler.HandleAsync(query);
        }
    }
}
