using System.ComponentModel.DataAnnotations;

namespace ProductFE.Models 
{
    public class Product
    {
        public int Id {get; set;}
        [Required(ErrorMessageResourceName = "You must set a name for your product.")]
        public string? Name {get; set;}
        [Required(ErrorMessageResourceName = "You must set a price for your product.")]
        public decimal Price {get; set;}
        [Required]
        [Range(0,1000)]
        public int StockQuantity {get; set;}
        public string? ImageUrl { get; set; }
        public string? ImageFileName { get; set; }
    }
    public class CartItemDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}