using Microsoft.AspNetCore.Mvc;
using FinalProject.Data;
using FinalProject.Data.Models;

namespace FinalProject.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            var allorders = new List<Orden>()
            {
                    new Orden()
                    {
                        Id = 1,
                        ProviderId = 2,
                        UserId = 3,
                        Total = 5000
                    },

                    new Orden()
                    {
                        Id = 2,
                        ProviderId = 3,
                        UserId = 2,
                        Total = 500
                    },

                    new Orden()
                    {
                        Id = 3,           
                        ProviderId = 1,
                        UserId = 1,
                        Total = 2000
                    }
            };
            return View(allorders);
        }
    }
}
