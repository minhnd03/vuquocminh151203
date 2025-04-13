using Microsoft.AspNetCore.Mvc;
using MvcDemoApp.Models;
using System.Collections.Generic;

namespace MvcDemoApp.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.0M },
            new Product { Id = 2, Name = "Product B", Price = 20.0M },
            new Product { Id = 3, Name = "Product C", Price = 30.0M }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
