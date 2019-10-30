using Microsoft.AspNetCore.Mvc;

namespace FavoriteMovies.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet("")]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("movie/{title}")]
        public JsonResult FindMovie(string title, int year, int runtime, string rating, string genre, string director, string actors, string plot)
        {
            var response = new{movie=title, release=year, runTime = runtime, movieRating = rating, genre = genre, movieDirector = director, actors = actors, moviePlot = plot};
            return Json(response);
        }
    }
}