using LiteLoungeProject.StaticService.Application.Models.ViewModels;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetEventQuery
    {
        public int Id { get; set; }

        public class QueryResult
        {
            public EventViewModel EventModel { get; set; }
        }
    }
}
