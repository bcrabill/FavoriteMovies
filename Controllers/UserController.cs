using System.Linq;
using FavoriteMovies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace FavoriteMovies.Controllers
{
    public class UserController : Controller
    {
        private HomeContext dbContext;

        public UserController(HomeContext context)
        { 
            dbContext = context;
        }
        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                return View("Index");
            }
            else
            {
                return View("Index");            
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault( u=> u.Email == logUser.LoginEmail);
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);

                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                    ViewBag.UserId = userInDb.UserId;
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
            
        }


    }
}