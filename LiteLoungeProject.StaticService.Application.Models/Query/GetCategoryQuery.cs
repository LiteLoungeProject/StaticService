using LiteLoungeProject.StaticService.Application.Models.ViewModels;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetCategoryQuery
    {
        public int Id { get; set; }

        public class QueryResult
        {
            public CategoryViewModel CategoryModel { get; set; }
        }
    }
}
