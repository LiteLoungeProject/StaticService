using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Contracts
{
    public interface IEventsRepository
    {
        Task<List<EventEntity>> GetCurrentEventsAsync();

        Task<EventEntity> GetEventAsync(int id);
    }
}
