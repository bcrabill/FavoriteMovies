using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FavoriteMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace FavoriteMovies.Controllers
{
    public class MovieController : Controller
    {
        private HomeContext dbContext; 

        public MovieController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        [Route("")]
        public IActionResult Index()
        {
            //List<Movie> allFavorites = dbContext.Movies.Include( u => u.FavoritedBy).ToList();

            return View("Index");
        }

       
        [HttpGet("movie/RocketMan")]
        [Route("movie/RocketMan")]
        public async Task<ActionResult> GetTitle(string title)
        {
           
            List<Movie> movieResultsList = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com?apikey=8bc90e0b&t=Rocket+man");
                var task = await client.GetAsync(client.BaseAddress);
                var jsonString = await task.Content.ReadAsStringAsync();
                Console.WriteLine(jsonString);
                var movieResult = JsonConvert.DeserializeObject<Movie>(jsonString);
                return View("MovieDetails", movieResult);
            }           
        }

       

    }
}