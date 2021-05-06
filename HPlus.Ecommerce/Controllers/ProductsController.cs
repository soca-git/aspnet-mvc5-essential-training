using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Product");
        }

        [Route("product/{productName:string?}")]
        public ActionResult Detail(string productName = null)
        {
            // lookup the product name in the database
            return View();
        }
    }
}