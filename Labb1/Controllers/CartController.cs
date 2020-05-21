using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Labb1.Services;
using Labb1.ViewModels;
using Labb1.Models;

namespace Labb1.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService productService;
        private readonly UserManager<IdentityUser> userManager;

        public CartController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
            this.productService = new MockProductService();
        }

        public IActionResult Index()
        {
            var cart = Request.Cookies.SingleOrDefault(cookie => cookie.Key == "cart");
            var cartIds = cart.Value.Split(',');
            var products = productService.GetAll();

            CartViewModel vm = new CartViewModel();
            vm.CreatedTicks = DateTime.Now.Ticks;
            vm.Products = new Dictionary<int, CartItem>();

            foreach (string idStr in cartIds)
            {
                int id = int.Parse(idStr);

                if (vm.Products.ContainsKey(id))
                    vm.Products[id].Amount++;
                else
                {
                    vm.Products.Add(id,
                        new CartItem() { Product = productService.GetByID(id), Amount = 1 });
                }
                    


            }

            // Totalpris.
            decimal total = 0m;
            foreach (var item in vm.Products.Values)
            {
                total += (item.Product.Price * item.Amount);
            }
            vm.TotalPrice = total;
            ///

            return View(vm);
        }

        [HttpPost]
        public IActionResult PlaceOrder([Bind("TotalPrice,Products")]CartViewModel vm)
        {
            Order order = new Order();
            order.TotalPrice = vm.TotalPrice;
            order.Date = DateTime.Now;
            order.OrderRows = vm.Products.Values.ToOrderRowList();
            order.UserID = int.Parse(userManager.GetUserId(User));

            return RedirectToAction("OrderSuccess", order);
        }

        public IActionResult OrderSuccess(Order order)
        {

            return View(order);
        }
    }
}