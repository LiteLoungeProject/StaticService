using LiteLoungeProject.StaticService.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Contracts
{
    public interface ICategoriesService
    {
        Task<List<CategoryModel>> GetCurrentCategoriesAsync();

        Task<CategoryModel> GetCategoryAsync(int id);
    }
}
