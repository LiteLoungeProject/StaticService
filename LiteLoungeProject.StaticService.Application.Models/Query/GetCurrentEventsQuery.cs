using LiteLoungeProject.StaticService.Application.Models.ViewModels;
using System.Collections.Generic;

namespace LiteLoungeProject.StaticService.Application.Models.Query
{
    public class GetCurrentEventsQuery
    {
        public class QueryResult
        {
            public List<EventViewModel> CurrentEventModels { get; set; }
        }
    }
}
