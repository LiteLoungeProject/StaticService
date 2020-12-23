using LiteLoungeProject.StaticService.Application.Handlers.Query;
using LiteLoungeProject.StaticService.Application.Models.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Appliation.WebApi.Controllers.Query
{

    [ApiController]
    [Route("api/query/categories")]
    public class CategoriesQueryController : ControllerBase
    {
        private readonly ILogger<CategoriesQueryController> _logger;
        private readonly CategoriesQueryHandler _handler;

        public CategoriesQueryController(CategoriesQueryHandler handler, ILogger<CategoriesQueryController> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        [HttpGet("currentCategories")]
        public async Task<GetCurrentCategoriesQuery.QueryResult> GetCurrentCategoriesAsync()
        {
            return await _handler.HandleAsync();
        }

        [HttpGet("category")]
        public async Task<GetCategoryQuery.QueryResult> GetCategoryAsync([FromQuery] GetCategoryQuery query)
        {
            return await _handler.HandleAsync(query);
        }
    }
}
