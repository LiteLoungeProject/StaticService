using LiteLoungeProject.StaticService.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Contracts
{
    public interface IPromotionsService
    {
        Task<List<PromotionModel>> GetCurrentPromotionsAsync();

        Task<PromotionModel> GetPromotionAsync(int id);
    }
}
