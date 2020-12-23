using LiteLoungeProject.StaticService.Persistence.Contracts;
using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Repositories
{
    public class PromotionsRepository : IPromotionsRepository
    {
        private readonly string _connectionString;

        public PromotionsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<PromotionEntity>> GetCurrentPromotionsAsync()
        {
            return new List<PromotionEntity>
            {
               new PromotionEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl"
               },
               new PromotionEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl"
               },
               new PromotionEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl"
               }
            };
        }

        public async Task<PromotionEntity> GetPromotionAsync(int id)
        {
            return new PromotionEntity
            {
                Id = 0,
                Title = "title",
                Text = "text",
                ImageUrl = "imageUrl"
            };
        }
    }
}
