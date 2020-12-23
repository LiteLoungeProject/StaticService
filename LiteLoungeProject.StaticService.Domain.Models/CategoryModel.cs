using System.Collections.Generic;

namespace LiteLoungeProject.StaticService.Domain.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string ImageUrl { get; set; }

        public List<ProductModel> ProductModels { get; set; }
    }
}
