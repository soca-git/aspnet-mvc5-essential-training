﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Filters
{
    public class LogRequestFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var log = new
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IP = filterContext.HttpContext.Request.UserHostAddress,
                DateTime = filterContext.HttpContext.Timestamp
            };

            // var declaration is implicit typing, like python.
            var json_log = JsonConvert.SerializeObject(log);
            Debug.WriteLine(json_log);
        }
    }
}