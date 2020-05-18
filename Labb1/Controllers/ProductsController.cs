using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Labb1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}