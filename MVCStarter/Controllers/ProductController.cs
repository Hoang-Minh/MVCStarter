using MVCStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStarter.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //ViewBag.SomeMessage = "I miss you";
            ViewBag.Message1 = "I miss you";
            List<Product> products = new List<Product>();
            products.Add(new Product() { ProductId = 1, ProductName = "Minh1" });
            products.Add(new Product() { ProductId = 2, ProductName = "Minh2" });
            products.Add(new Product() { ProductId = 3, ProductName = "Minh3" });
            products.Add(new Product() { ProductId = 4, ProductName = "Minh4" });

            return View(products);
        }

        public ActionResult PartialProduct()
        {
            ViewBag.Message = "Partial Product";

            return View();
        }

        public ActionResult ProductDetails()
        {
            return View();
        }
    }
}