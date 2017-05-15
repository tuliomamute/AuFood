using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View("Products");
        }
    
        public ActionResult AboutUs()
        {
            return View("AboutUs");
        }
    }
}