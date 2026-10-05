using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> Products =
        [
            new Product { Id = 1, Name = "Ноутбук", Description = "Легкий ноутбук з екраном 15.6\" для роботи та навчання.", Price = 25999, Emoji = "💻" },
            new Product { Id = 2, Name = "Смартфон", Description = "Смартфон з камерою 50 Мп та батареєю на 5000 мА·год.", Price = 12499, Emoji = "📱" },
            new Product { Id = 3, Name = "Навушники", Description = "Бездротові навушники з активним шумозаглушенням.", Price = 3299, Emoji = "🎧" }
        ];

        public IActionResult Index()
        {
            return View(Products);
        }

        public IActionResult Details(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
