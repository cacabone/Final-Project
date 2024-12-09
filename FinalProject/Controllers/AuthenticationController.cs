using FinalProject.Data;
using FinalProject.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AuthenticationController : Controller
    {

        public IActionResult Users()
        {
            var allusers = new List<User>()
            { 
                    new User()
                    {
                        Id = 1,
                        Name = "Test1",
                        Email = "Test1",
                        Password = "Test1",                  
                    },

                    new User()
                    {
                        Id = 2,
                        Name = "Test2",
                        Email = "Test2",
                        Password = "Test2",
                    },
                    
                    new User()
                    {
                        Id = 3,
                        Name = "Test3",
                        Email = "Test3",
                        Password = "Test3",
                    }
            };

            return View(allusers);
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Remove(int RemoveUser) 
        {
            return View();
        }
    }
}
