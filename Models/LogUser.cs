using System.ComponentModel.DataAnnotations;

namespace FavoriteMovies.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string LoginEmail { get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Your password must be at leat 8 characters")]
        [Display(Name="Password")]
        public string LoginPassword {get;set;}
    }
}