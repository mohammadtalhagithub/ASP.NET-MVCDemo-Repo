using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using BusinessLayer; // Dependency for EmployeeBusinessLayer Class, present in BusinessLayer Class Library

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            string url = "http://localhost:49981/Employee/viewData";
            ViewBag.URL = url;

            return View(employees);
        }

        /// <summary>
        /// ActionResult Class is an abstract parent/base class.
        /// </summary>
        /// <returns></returns>
        public ActionResult Card()
        {
            return View();
        }

        public string StudentID(int id)
        {
            return "<h1>The StudentID is : " + id;
        }

        
        /// <summary>
        /// This Controller Action method will only respond to a Get request of this URL.
        /// <para></para>
        /// This is done by using a [HttpGet] attribute, which is used to restrict the "Create" Action Method to handle only Http Get requests.
        /// <para></para>
        /// See : <see cref="HttpGetAttribute"/>
        /// <para></para>
        /// <returns>returns : View(). </returns>
        /// </summary>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult viewData()
        {
            string[] strArray = new string[]
            { "One", "Two", "Three" };

            List<string> SportsList = new List<string>
            {
                "Cricket",
                "Football",
                "Baseball",
                "Vollyball"
            };

            DataClass DataClassObj_1 = new DataClass();
            DataClassObj_1.ID = 007;
            DataClassObj_1.Name = "James Bond";
            DataClassObj_1.Designation = "Underccover Agent";

            DataClass DataClassObj_2 = new DataClass();
            DataClassObj_2.ID = 008;
            DataClassObj_2.Name = "John Conner";
            DataClassObj_2.Designation = "RAW Agent";


            List<DataClass> DataClassList = new List<DataClass>()
            {
                DataClassObj_1, DataClassObj_2
            };


            ViewData["MyCurrentTime"] = DateTime.Now.ToLongTimeString();
            ViewData["Array"] = strArray;
            ViewData["List"] = SportsList;

            ViewBag.MyCurrentTime = DateTime.Now.ToLongTimeString();
            ViewBag.List = SportsList;

            ViewBag.AgentsList = DataClassList;
            
            var variable = true;
            ViewBag.VarType = variable.GetType();

            

            return View();
        }
    }
}