using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// if not following the View naming convention, then
        /// We must pass a valid .cshtml file name inside View().
        /// </summary>
        /// <returns></returns>
        public ActionResult Home()
        {
            ViewBag.StringFromData = Data();

            return View("homepage"); // Index Action Method returns the "homepage.cshtml" file.
        }

        [NonAction]
        public string Data()
        {
            return "A string returned by [NonAction] attribute function.";
        }

        public ActionResult Index()
        {
            ViewData["Var1"] = "Data comes from ViewData.";
            ViewBag.Var2 = "Data comes from ViewBag.";
            TempData["Var3"] = "Data comes from TempData.";
            Session["Var4"] = "Data comes from Session.";

            return View();
        }

        public ActionResult About()
        {
            if (Session["Var4"] != null)
            {
                Session["Var4"].ToString();
            }
            TempData.Keep();
            return View();
        }

        public ActionResult Contact()
        {
            if (Session["Var4"] != null)
            {
                Session["Var4"].ToString();
            }

            return View();
        }
    }
}