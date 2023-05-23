using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharedViews.Models;


namespace SharedViews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Admin()
        {

            return View();
        }

        /// <summary>
        /// See : <see cref="EducationModel"/> class
        /// </summary>
        /// <returns></returns>
        public ActionResult Education()
        {

            ViewBag.EducationList = EdListFunc();


            // For strongly typed view, the return View() must contain some parameter inside to return, 
            // such as an Object or a Collection of Objects.
            return View(EdListFunc());
        }

        /// <summary>
        /// Non-Action Method, this returns a complex List object, of type EducationModel.
        /// </summary>
        /// <returns></returns>
        [NonAction]
        public List<EducationModel> EdListFunc()
        {
            EducationModel Masters = new EducationModel()
            {
                Course = "M.Tech",
                CourseFull = "Master of Technology",
                Branch = "Mechanical Engg",
                College = "ZHCET",
                University = "AMU",
                City = "Aligarh",
                Year = "2021"

            };
            EducationModel Bachelors = new EducationModel()
            {
                Course = "BE",
                CourseFull = "Bachelor of Engineering",
                Branch = "Mechanical Engg",
                College = "ZHCET",
                University = "AMU",
                City = "Aligarh",
                Year = "2018"

            };

            EducationModel Diploma = new EducationModel()
            {
                Course = "Diploma",
                CourseFull = "Diploma in Engineering",
                Branch = "Mechanical Engg",
                College = "University Polytechnic",
                University = "AMU",
                City = "Aligarh",
                Year = "2014"

            };

            List<EducationModel> EduList = new List<EducationModel>()
            {
                Masters, Bachelors, Diploma
            };

            return EduList;
        }

        public ActionResult PartialViews()
        {
            return View();
        }   

    }
}