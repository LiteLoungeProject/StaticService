using LiteLoungeProject.StaticService.Application.Models.ViewModels;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetProductQuery
    {
        public int Id { get; set; }

        public class QueryResult
        {
            public ProductViewModel ProductModel { get; set; }
        }
    }
}
