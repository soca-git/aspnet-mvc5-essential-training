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

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            }

            return View();
        }
    }
}