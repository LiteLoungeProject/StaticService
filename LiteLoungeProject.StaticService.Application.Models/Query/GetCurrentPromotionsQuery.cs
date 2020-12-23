using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using System.Collections.Generic;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetCurrentPromotionsQuery
    {
        public class QueryResult
        {
            public List<PromotionViewModel> CurrentPromotionModels { get; set; }
        }
    }
}
