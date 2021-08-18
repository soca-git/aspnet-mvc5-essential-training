using HPlus.Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlus.Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            // return View();
            return View("List");
            // return View("~/Views/Product/List.cshtml");
        }

        [Route("product/{productName}")]
        public ActionResult Detail(string productName)
        {
            // hard-coded example.
            ViewBag.Product = new Product
            {
                Name = "Women's Winter Jacket",
                FullPrice = 20.00M,
                CurrentPrice = 16.00M,
                PercentDiscount = 20,
                ImagePath = "/Content/Images/Products/1.jpg",
                StarRating = 4
            };
            // lookup the product name in the database
            return View();
        }
    }
}