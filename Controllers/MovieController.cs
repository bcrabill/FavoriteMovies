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

       
        [HttpGet("movie/{Title}")]
        [Route("movie/{Title}")]
        
        public async Task<ActionResult> GetTitle(string Title)
        {
            var newTitle = Title.Replace(' ','+');
            Console.WriteLine("the new title is "+ newTitle);
            
            using (var client = new HttpClient())
            {
                string url = "http://www.omdbapi.com?";
                string apiKey = "apikey=8bc90e0b&";
                string titleInput = "t="+newTitle;
                client.BaseAddress = new Uri(url+apiKey+titleInput);
                var task = await client.GetAsync(client.BaseAddress);
                var jsonString = await task.Content.ReadAsStringAsync();
                Console.WriteLine(jsonString);
                var movieResult = JsonConvert.DeserializeObject<Movie>(jsonString);
                return View("MovieDetails", movieResult);
            }           
        }

       

    }
}