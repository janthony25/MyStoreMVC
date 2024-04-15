using Microsoft.AspNetCore.Mvc;
using MyStoreMVC.Services;

namespace MyStoreMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }
    }
}
