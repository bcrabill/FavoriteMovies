using System;
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
                Console.WriteLine("*******************Reg user model is valid");
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                HttpContext.Session.SetString("Name", newUser.FirstName);
                ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
                ViewBag.Name = HttpContext.Session.GetString("Name");
                return RedirectToAction("Dashboard", newUser);
            }
            else
            {
                Console.WriteLine("*******************Reg user model is not valid");
                return View("Index");            
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u=> u.Email == logUser.LoginEmail);
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$user in db is supposed to be here" + userInDb);
                if(userInDb == null)
                {
                    Console.WriteLine("@@@@@@@@@Login userin DB is null@@@@@@@@@@@@@");
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index", "Movie");
                }
                else
                {
                    Console.WriteLine("@@@@@@@@@Login userin DB is not null@@@@@@@@@@@@@");
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    HttpContext.Session.SetString("Name", userInDb.FirstName);
                    ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
                    ViewBag.Name = HttpContext.Session.GetString("Name");
                    return RedirectToAction("Dashboard", userInDb);
                }
            }
            else
            {
                return View("Index");
            }
            
        }


    }
}