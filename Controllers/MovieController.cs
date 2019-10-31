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
        public JsonResult FindMovie(string title)
        {
            
            return Json(response);
        }
        public IActionResult AddMovie

        public IActionResult RemoveMovie
        
    }
}