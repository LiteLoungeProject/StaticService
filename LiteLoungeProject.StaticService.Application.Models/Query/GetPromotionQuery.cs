using LiteLoungeProject.StaticService.Application.Models.ViewModels;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetPromotionQuery
    {
        public int Id { get; set; }

        public class QueryResult
        {
            public PromotionViewModel PromotionModel { get; set; }
        }
    }
}
