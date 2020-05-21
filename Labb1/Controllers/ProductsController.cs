using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Labb1.Services;
using Labb1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Labb1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        
        public ProductsController()
        {
            this.productService = new MockProductService();
        }
        
        public IActionResult Index()
        {
            var products = productService.GetAll();

            return View(products);
        }

        [Authorize]
        public IActionResult AddToCart(int id)
        {
            var cart = Request.Cookies.SingleOrDefault(cookie => cookie.Key == "cart");
            string cartContent = "";

            if (cart.Value != null)
            {
                cartContent = cart.Value;
                cartContent += "," + id;
            }
            else
            {
                cartContent = id.ToString();
            }

            Response.Cookies.Append("cart", cartContent);

            return RedirectToAction("Index");
        }



    }
}