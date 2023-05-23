using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharedViews.Models;

namespace SharedViews.Controllers
{
    public class StronglyTypedPartialViewController : Controller
    {
        /// <summary>
        /// Creating a list "ProductsList" of Objects of Class Product and
        /// initializing the Objects without explicitely declaring their names.
        /// </summary>
        List<Product> ProductsList = new List<Product>()
        {
            new Product {ID = 1, Name = "Zixer Shoes", Price = 10000.00, Picture = "~/Images/Shoes.png" },
            new Product {ID = 2, Name = "ReyBen Sunglasses", Price = 1000.00, Picture = "~/Images/Sunglasses.png" },
            new Product {ID = 3, Name = "Smart Watch", Price = 15000.00, Picture = "~/Images/Watch.png" },
            new Product {ID = 4, Name = "T-Shirt", Price = 5000.00, Picture = "~/Images/T-Shirt.png" }            
        };

        // GET: StronglyTypedPartialView
        public ActionResult Index()
        {
            return View(ProductsList); // Pass "ProductsList" for Strongly Typed View.
        }
    }
}