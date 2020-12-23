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
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 10m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 20m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 30m }
                   }
               },
               new CategoryEntity
               {
                    Id = 1,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",

                     ProductModels = new List<ProductModel>
                   {
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 10m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 20m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 30m }
                   }
               },
               new CategoryEntity
               {
                    Id = 2,
                    Title = "title",
                    Text = "text",
                    ImageUrl = "imageUrl",

                     ProductModels = new List<ProductModel>
                   {
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 10m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 20m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 30m }
                   }
               }
            };
        }

        public async Task<CategoryEntity> GetCategoryAsync(int id)
        {
            return new CategoryEntity
            {
                Id = 0,
                Title = "title",
                Text = "text",
                ImageUrl = "imageUrl",

                ProductModels = new List<ProductModel>
                   {
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 10m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 20m },
                     new ProductModel{ Id = 0, Title = "title", Text = "text", ImageUrl = "imageUrl", Price = 30m }
                   }
            };
        }
    }
}
