namespace LiteLoungeProject.StaticService.Domain.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public int CategoryModelId { get; set; }

        public CategoryModel CategoryModel { get; set; }
    }
}
