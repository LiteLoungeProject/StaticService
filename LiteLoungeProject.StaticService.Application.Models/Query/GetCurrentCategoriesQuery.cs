using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using System.Collections.Generic;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetCurrentCategoriesQuery
    {
        public class QueryResult
        {
            public List<CategoryViewModel> CurrentCategoryModels { get; set; }
        }
    }
}
