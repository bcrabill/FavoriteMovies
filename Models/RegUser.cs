using System.ComponentModel.DataAnnotations;


namespace FavoriteMovies.Models
{
    public class RegUser
    {
        [Display(Name="First Name")]
         public string FirstName {get; set;}
        [Required]
        
        [Display(Name = "Last Name")]
        public string LastName {get;set;}
        [Required]

        
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get; set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Your pasword must be at least 8 characters")]
        [Display(Name = "Password")]
        public string Password { get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Your pasword must be at least 8 characters")]
        [CompareAttribute("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword {get; set;}
        
    }
}