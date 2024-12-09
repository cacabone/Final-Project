using Microsoft.AspNetCore.Mvc;
using FinalProject.Data.Models;
using FinalProject.Data;
namespace FinalProject.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {            
            var data = _context.Products.ToList();
            return View();
        }
    }
}
