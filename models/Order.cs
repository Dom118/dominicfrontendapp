// using System.ComponentModel.DataAnnotations;

// namespace OrderFE.Models 
// {
//     public class Order
//     {
//         public int Id {get; set;}
//         [Required(ErrorMessageResourceName = "You must set a name for your product.")]
//         public string? Name {get; set;}
//         [Required(ErrorMessageResourceName = "You must set a price for your product.")]
//         public decimal Price {get; set;}
//         [Required]
//         [Range(0,1000)]
//         public int StockQuantity {get; set;}
//     }
// }