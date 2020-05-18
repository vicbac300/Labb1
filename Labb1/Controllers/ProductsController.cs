using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Labb1.Models;

namespace Labb1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.AddRange(
            new Product[] {
                new Product() { ID = 1, Name = "Bästa produkten", Price = 100m }
            }
                );

            return View(products);
        }
    }
}