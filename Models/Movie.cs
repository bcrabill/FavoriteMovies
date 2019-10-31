namespace FavoriteMovies.Models
{
    public class Movie
    {
        [Key]
        public int MovieId;
        public string Title;
        public string Actor;

        public string Director;

        public string Plot;

        public string Released;

        public int Rating;

        public string Genre;

        public string Poster;

        public Movie(string title, string actor, string director, string plot, string released, int rating, string genre, string poster, int movieId)
        {
            MovieId = movieId;
            Title = title;
            Actor = actor;
            Director = director;
            Plot = plot;
            Released = released;
            Rating = rating;
            Genre = genre;
            Poster = poster;
        }

        //Navigational Properties
        public User FavoritedBy { get; set;}

        public List<Favorite> UserFavorites { get; set;}
    }
}