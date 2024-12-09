using FinalProject.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ProvidersController : Controller
    {
        public IActionResult ProvidersView()
        {
            var allproviders = new List<Provider>()
            {
                    new Provider()
                    {
                        Id = 1,
                        Name = "Test1",
                        Contact = "testcontact1",
                        PhoneNumber = "000-000-0000",
                        Email = "Test1@example.com"
                    },

                    new Provider()
                    {
                        Id = 2,
                        Name = "Test2",
                        Contact = "testcontact1",
                        PhoneNumber = "000-000-0000",
                        Email = "Test2@example.com"

                    },

                    new Provider()
                    {
                        Id = 3,
                        Name = "Test3",
                        Contact = "testcontact1",
                        PhoneNumber = "000-000-0000",
                        Email = "Test3@example.com",
                        
                    }
            };

            return View(allproviders);
        }
    }
}
