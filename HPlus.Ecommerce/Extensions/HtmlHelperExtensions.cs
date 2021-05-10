using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Namespace changed to be the one HtmlHelper uses.
namespace System.Web.Mvc
{
    // Static class.
    public static class HtmlHelperExtensions
    {
        // 'this' placed prior to the HtmlHelper parameter indicates to the compiler
        // that the Copyright method is an extension method of the HtmlHelper class.
        // Now this method can be called in the view by using @Html.Copyright().
        // Html is an instance of HtmlHelper!
        public static IHtmlString Copyright(this HtmlHelper helper)
        {
            // syntax to enable nesting of DateTime call.
            // IHtmlString & helper.Raw enables this string to be returned without
            // being html encoded, allowing the &copy to render correctly.
            return helper.Raw($"&copy; H+ Sport {DateTime.Now.Year}");
        }
    }
}