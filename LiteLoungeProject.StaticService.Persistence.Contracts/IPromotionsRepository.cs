using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Contracts
{
    public interface IPromotionsRepository
    {
        Task<List<PromotionEntity>> GetCurrentPromotionsAsync();

        Task<PromotionEntity> GetPromotionAsync(int id);
    }
}
