using LiteLoungeProject.StaticService.Domain.Models;
using LiteLoungeProject.StaticService.Persistence.Contracts;
using LiteLoungeProject.StaticService.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiteLoungeProject.StaticService.Persistence.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly string _connectionString;

        public CategoriesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<CategoryEntity>> GetCurrentCategoriesAsync()
        {
            return new List<CategoryEntity>
            {
               new CategoryEntity
               {
                    Id = 0,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",

                     ProductModels = new List<ProductModel>
                   {
                     new ProductModel{ Id = 1, Title = "title1", Text = "text1", ImageUrl = "imageUrl-1", Price = 1 },
                     new ProductModel{ Id = 2, Title = "title2", Text = "text2", ImageUrl = "imageUrl-2", Price = 2 },
                     new ProductModel{ Id = 3, Title = "title3", Text = "text3", ImageUrl = "imageUrl-3", Price = 3 }
                   }
               },
               new CategoryEntity
               {
                    Id = 1,
                    Title = "title-1",
                    Text = "text-1",
                    ImageUrl = "imageUrl-1",

                     ProductModels = new List<ProductModel>
                   {
                     new ProductModel{ Id = 4, Title = "title4", Text = "text4", ImageUrl = "imageUrl-4", Price = 4 },
                     new ProductModel{ Id = 5, Title = "title5", Text = "text5", ImageUrl = "imageUrl-5", Price = 5 },
                     new ProductModel{ Id = 6, Title = "title6", Text = "text6", ImageUrl = "imageUrl-6", Price = 6 }
                   }
               }
            };
        }

        public async Task<CategoryEntity> GetCategoryAsync(int id)
        {
            return new CategoryEntity
            {
                Id = 1,
                Title = "title1",
                Text = "text1",
                ImageUrl = "imageUrl-1",

                ProductModels = new List<ProductModel>
                   {
                      new ProductModel{ Id = 4, Title = "title4", Text = "text4", ImageUrl = "imageUrl-4", Price = 4 },
                     new ProductModel{ Id = 5, Title = "title5", Text = "text5", ImageUrl = "imageUrl-5", Price = 5 },
                     new ProductModel{ Id = 6, Title = "title6", Text = "text6", ImageUrl = "imageUrl-6", Price = 6 }
                   }
            };
        }
    }
}
