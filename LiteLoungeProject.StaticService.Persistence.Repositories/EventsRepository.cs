using LiteLoungeProject.StaticService.Persistence.Contracts;
using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Repositories
{
    public class EventsRepository : IEventsRepository
    {
        private readonly string _connectionString;

        public EventsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<EventEntity>> GetCurrentEventsAsync()
        {
            return new List<EventEntity>
            {
               new EventEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl"
               },
               new EventEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl"
               },
               new EventEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl"
               }
            };
        }

        public async Task<EventEntity> GetEventAsync(int id)
        {
            return new EventEntity
            {
                Id = 0,
                Title = "title",
                Text = "text",
                ImageUrl = "imageUrl"
            };
        }
    }
}
