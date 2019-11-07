using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace FavoriteMovies.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set;}

        [Required(ErrorMessage = "An email address is required")]
        [EmailAddress]
        public string Email { get; set;}

        [Required(ErrorMessage = "You must have a first name")]
        public string FirstName {get; set;}
        [Required(ErrorMessage = "You must have a last name")]
        public string LastName {get;set;}
        [Required(ErrorMessage = "You must enter a password")]

        public string Password {get; set;}

        [NotMapped]
        [Required]
        [MinLength(8, ErrorMessage = "Your pasword must be longer")]
        [DataType(DataType.Password)]       
        [Compare("Password")]
        public string ConfirmPassword {get; set;}

        public List<Favorite> myFavorites {get; set;}

        public List<Movie> Favorite {get; set;}
    }
}