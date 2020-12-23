using LiteLoungeProject.StaticService.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Contracts
{
    public interface IEventsService
    {
        Task<List<EventModel>> GetCurrentEventsAsync();

        Task<EventModel> GetEventAsync(int id);
    }
}
