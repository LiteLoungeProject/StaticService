using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Contracts
{
    public interface ICategoriesRepository
    {
        Task<List<CategoryEntity>> GetCurrentCategoriesAsync();

        Task<CategoryEntity> GetCategoryAsync(int id);
    }
}
