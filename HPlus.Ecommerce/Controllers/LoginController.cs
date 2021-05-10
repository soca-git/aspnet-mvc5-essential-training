using HPlus.Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlus.Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Login request)
        {
            Debug.WriteLine(request.Username + " " + request.Password);
            if (!string.IsNullOrEmpty(request.Username) && !string.IsNullOrEmpty(request.Password))
            {
                FormsAuthentication.SetAuthCookie(request.Username, false);
                return Redirect(FormsAuthentication.GetRedirectUrl(request.Password, false));
            }
            // ViewBag.Failed = true; test invalid submission.
            return View(request);
        }
    }
}