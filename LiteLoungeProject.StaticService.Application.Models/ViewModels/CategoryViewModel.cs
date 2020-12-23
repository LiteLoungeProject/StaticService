using LiteLoungeProject.StaticService.Domain.Models;
using System.Collections.Generic;

namespace LiteLoungeProject.StaticService.Application.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string ImageUrl { get; set; }

        public List<ProductModel> ProductModels { get; set; }
    }
}

