using LiteLoungeProject.StaticService.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Domain.Contracts
{
    public interface IProductsService
    {
        Task<List<ProductModel>> GetCurrentProductsAsync();

        Task<ProductModel> GetProductAsync(int id);
    }
}
