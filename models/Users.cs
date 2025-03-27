using System.ComponentModel.DataAnnotations;

namespace UserFE.Models 
{
    public class User
    {
        public int Id {get; set;}
        [Required(ErrorMessageResourceName = "You must enter a valid email address")]
        public string? Email {get; set;}
        [Required(ErrorMessageResourceName = "You must set a price for your product.")]
        public string? Password {get; set;}
      
    }
}