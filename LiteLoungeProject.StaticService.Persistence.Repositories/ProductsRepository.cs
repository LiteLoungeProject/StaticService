using LiteLoungeProject.StaticService.Persistence.Contracts;
using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly string _connectionString;

        public ProductsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<ProductEntity>> GetCurrentProductsAsync()
        {
            return new List<ProductEntity>
            {
               new ProductEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",
                    Price = 0.11m,
                    CategoryModelId = 0
               },
               new ProductEntity
               {
                    Id = 1,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",
                    Price = 0.11m,
                    CategoryModelId = 1
               },
               new ProductEntity
               {
                    Id = 2,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",
                    Price = 0.11m,
                    CategoryModelId = 0
               },
                new ProductEntity
               {
                    Id = 3,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",
                    Price = 0.11m,
                    CategoryModelId = 1
               },
                 new ProductEntity
               {
                    Id = 4,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",
                    Price = 0.11m,
                    CategoryModelId = 0
               }
            };
        }

        public async Task<ProductEntity> GetProductAsync(int id)
        {
            return new ProductEntity
            {
                Id = 0,
                Title = "title",
                Text = "text",
                ImageUrl = "imageUrl",
                Price = 0.11m,
                CategoryModelId = 0

            };
        }
    }
}
