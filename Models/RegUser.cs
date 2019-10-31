using System.ComponentModel.DataAnnotations;

namespace FavoriteMovies.Models
{
    public class RegUser
    {
         public string FirstName {get; set;}
        [Required]
        public string LastName {get;set;}
        [Required]

        
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get; set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Your pasword must be longer")]
        [Display(Name = "Password")]
        public string Password { get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        
        public string ConfirmPassword {get; set;}
        
    }
}