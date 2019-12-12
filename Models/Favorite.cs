using System.Collections.Generic;
namespace FavoriteMovies.Models
{
    public class Favorite
    {
        public int UserId { get;set;}
        public int MovieId { get; set;}

        public int FavoriteId {get;set;}

        //Navigational Properties
        public User UserFavorited {get; set; }

        public Movie Favorited {get; set;}
    }
}