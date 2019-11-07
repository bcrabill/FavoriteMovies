using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FavoriteMovies.Models
{
    public class Movie
    {
        [Key]
        public int MovieId {get;set;}
        [Required]
        [JsonProperty("Title")]
        public string Title {get;set;}

        [JsonProperty("Actors")]
        public string Actor {get;set;}

        [JsonProperty("Director")]
        public string Director {get;set;}
        [JsonProperty("Plot")]
        public string Plot {get;set;}

        [JsonProperty("Released")]
        public string Released {get;set;}
        [JsonProperty("Rating")]
        public int Rating {get;set;}

        [JsonProperty("Genre")]
        public string Genre {get;set;}
        [JsonProperty("Poster")]
        public string Poster {get;set;}

        public Movie(string title, string actor, string director, string plot, string released, int rating, string genre, string poster, int movieId)
        {
            Title = title;
            Actor = actor;
            Director = director;
            Plot = plot;
            Released = released;
            Rating = rating;
            Genre = genre;
            Poster = poster;
            MovieId = movieId;
        }

        //Navigational Properties
        public User FavoritedBy { get; set;}

        public List<Favorite> Favorites { get; set;}
    }
}