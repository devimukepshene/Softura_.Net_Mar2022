using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core2.Models;

namespace Core2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductDBcontext Context = new ProductDBcontext();
                Context.Add(p);
                Context.SaveChanges();
                Console.Read();
                return Content("Saved");

            }
            return View("Index");
        }
    }
}
