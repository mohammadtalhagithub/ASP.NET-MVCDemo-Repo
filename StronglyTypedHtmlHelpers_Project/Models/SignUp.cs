using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedHtmlHelpers_Project.Models
{
    public class SignUp
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string UserGender { get; set; }

        public string UserEmail { get; set; }

        public string UserComment { get; set; }

        public string UserPage { get; set; }
    }
}