using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FavoriteMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;


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
        
        public async static GetAsync(string title)
        {
            Console.WriteLine("*************GetASYNC***********");
           
            List<Movie> movieResultsList = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com?apikey=8bc90e0b&t=Rocket+man");
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                Console.WriteLine(response);
                
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("***************************");
                Console.WriteLine(result);

                deserialiseJSON(result);

                //return View ("MovieDetails", result);
            }           
        }

        private static void deserialiseJSON(string result)
        {
            try
            {
                Movie movieResult = JsonConvert.DeserializeObject<Movie>(result);
                Console.WriteLine("The actors are " + movieResult.Actor);
                Console.WriteLine("The director is " + movieResult.Director);
                Console.WriteLine("The plot is " + movieResult.Plot);      
               
            }
            catch
            {
                Console.WriteLine("There is a problem");
            }
        }

    }
}