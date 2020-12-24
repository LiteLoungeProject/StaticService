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
                   Id = 1, Title = "title1",
                   Text = "text1",
                   ImageUrl = "imageUrl-1",
                   Price = 1,
                   CategoryModelId = 0
               },
               new ProductEntity
               {
                   Id = 2, Title = "title2",
                   Text = "text2",
                   ImageUrl = "imageUrl-2",
                   Price = 2,
                   CategoryModelId = 0
               },
               new ProductEntity
               {
                   Id = 3, Title = "title3",
                   Text = "text3",
                   ImageUrl = "imageUrl-3",
                   Price = 3,
                   CategoryModelId = 0
               },
                new ProductEntity
               {
                    Id = 4,
                    Title = "title4",
                    Text = "text4",
                    ImageUrl = "imageUrl-4",
                    Price = 4,
                    CategoryModelId = 1
               },
                 new ProductEntity
               {
                    Id = 5,
                     Title = "title5",
                     Text = "text5",
                     ImageUrl = "imageUrl-5",
                     Price = 5,
                    CategoryModelId = 1
               },
                  new ProductEntity
               {
                   Id = 6,
                      Title = "title6",
                      Text = "text6",
                      ImageUrl = "imageUrl-6",
                      Price = 6,
                    CategoryModelId = 1
               }
            };
        }

        public async Task<ProductEntity> GetProductAsync(int id)
        {
            return new ProductEntity
            {

                Id = 6,
                Title = "title6",
                Text = "text6",
                ImageUrl = "imageUrl-6",
                Price = 6,
                CategoryModelId = 1

            };
        }
    }
}
