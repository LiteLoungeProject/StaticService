using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Contracts
{
    public interface IProductsRepository
    {
        Task<List<ProductEntity>> GetCurrentProductsAsync();

        Task<ProductEntity> GetProductAsync(int id);
    }
}
