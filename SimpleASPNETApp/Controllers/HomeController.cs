using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleASPNETApp.Models;

namespace SimpleASPNETApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Passage to example URL adress";

        }

        public ViewResult AutoProperty()
        {
            //Creating new object Product
            Product myProduct = new Product();

            //Setting value
            myProduct.Name = "POLSpeed paper";

            //Reading value
            string productName = myProduct.Name;

            return View("Result", (object)String.Format("Product name: {0}", productName));
        }
    }
}
