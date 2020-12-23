using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using System.Collections.Generic;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetCurrentProductsQuery
    {
        public class QueryResult
        {
            public List<ProductViewModel> CurrentProductModels { get; set; }
        }
    }
}
