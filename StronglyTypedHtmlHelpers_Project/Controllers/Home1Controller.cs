using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using StronglyTypedHtmlHelpers_Project.Models;

namespace StronglyTypedHtmlHelpers_Project.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View();
        }

        readonly string EmailPattern = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

        /// <summary>
        /// <para>This Index Action Method accepts only Post Request from the client.</para>
        /// <para>CalcObject is an instance of the Model Class <code>Calculation</code>.</para>
        /// </summary>
        /// <param name="CalcObject"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(Calculation CalcObject, string Num1, string Num2, string Email)
        {
            // Calculation
            int num1 = CalcObject.Num1;
            int num2 = CalcObject.Num2;

            int result = num1 + num2;
            ViewBag.Result = result;

            /*
             * Validation Message(string Num1, string Num2 are used same as html control names for Validation Messages
             * for textboxes with respective names)
             */

            if (Num1.Equals("") == true)
            {
                ModelState.AddModelError("Num1", "Num1 value is required...!");
                ViewBag.Num1Error = "*";
            }
            if (Num2.Equals("") == true)
            {
                ModelState.AddModelError("Num2", "Num2 value is required...!");
                ViewBag.Num2Error = "*";
            }
            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is required...!");
                ViewBag.EmailError = "*";
            }
            else
            {
                if (Regex.IsMatch(Email, EmailPattern) == false)
                {
                    ModelState.AddModelError("Email", "Invalid Email..!");
                    ViewBag.EmailError = "*";
                }
            }

            if (ModelState.IsValid == true) // if there is any error, then ModelState.IsValid returns false
            {
                string SuccessMessage = "<script>alert('Data has been submitted...!!')</script>";
                ViewBag.Message = SuccessMessage;

                ModelState.Clear();
            }

            return View();
        }
    }
}