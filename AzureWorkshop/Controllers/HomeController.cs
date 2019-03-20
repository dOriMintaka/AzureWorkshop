using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureWorkshop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is my second azure web application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here you can find my contacts.";

            return View();
        }
    }
}