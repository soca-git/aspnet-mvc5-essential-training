using HPlus.Ecommerce.Data;
using HPlus.Ecommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            Customer customer = null;
            using (var context = new HPlusSportDbContext())
            {
                // User is the currently logged in user, retrieved from the HTTP requesd.
                var user = context.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);

                // If the user object is not null (i.e. a match was found in the database).
                if (user != null)
                {
                    // Grab the customer object from the user.
                    customer = context.Customers.FirstOrDefault(c => c.CustomerID == user.CustomerId);
                }
            }
            return View(customer);
        }
    }
}