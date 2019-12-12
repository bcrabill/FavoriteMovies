using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FavoriteMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;



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
            if(HttpContext.Session.GetInt32("UserId")==null)
            {
            return View("Index");
            }
            else
            {
            return Redirect("/Dashboard");
            }
        }
        
        public IActionResult Dashboard(User activeUser)
        {
        if(HttpContext.Session.GetInt32("UserId") == null)
        {
            Console.WriteLine("#####Dashboard UserId is Null########");
            return View("Index");
        }
        else
        {
            User userInDb = dbContext.Users.FirstOrDefault( u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            Console.WriteLine("#####Dashboard UserId is NOT Null########");
            List<Movie> allFavorites = dbContext.Movies.Include( u => u.FavoritedBy == activeUser).ToList();
            return View("UserDashboard", allFavorites);
        }
        }

        public async Task<Movie> APIProcessor(string newTitle)
        {
            using (var client = new HttpClient())
            {
                string url = "http://www.omdbapi.com?";
                string apiKey = "apikey=8bc90e0b&";
                string titleInput = "t="+newTitle;
                client.BaseAddress = new Uri(url+apiKey+titleInput);
                Console.WriteLine("the url entered is"+client.BaseAddress);
                var task = await client.GetAsync(client.BaseAddress);
                var jsonString = await task.Content.ReadAsStringAsync();
                Console.WriteLine(jsonString);
                var movieResult = JsonConvert.DeserializeObject<Movie>(jsonString);
                return movieResult;
            }           
        }
        public IActionResult AddMovie(Movie newMovie)
        {
            User userInDb = dbContext.Users.FirstOrDefault( u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            else
            {
                if(ModelState.IsValid)
                {
                    Favorite newFavorite = new Favorite();
                    newFavorite.UserFavorited = userInDb;
                    newFavorite.MovieId = newMovie.MovieId;
                    dbContext.Favorites.Add(newFavorite);
                    dbContext.Movies.Add(newMovie);
                    dbContext.SaveChanges();
                    Console.WriteLine("the movie ", newMovie.Title + " was created");
                    return View("UserDashboard");
                }
                else
                {
                    return View("Index");
                }
            }
        }
        
        [HttpPost]
        [Route("movie")]
        public IActionResult TitleSearch(string Title)
        {
            Console.WriteLine("##########################################");
            var newTitle = Title.Replace(' ','+');
            Console.WriteLine("the new title is "+ newTitle);
            Movie movieTitle = APIProcessor(newTitle).Result;
            
            return View("MovieDetails", movieTitle);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}