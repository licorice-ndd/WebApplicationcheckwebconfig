using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationcheckwebconfig.Models;

namespace WebApplicationcheckwebconfig.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
/*            ListCoffee strLC = new ListCoffee();
            List<QuanLyCoffee> obj = strLC.getCoffee(string.Empty);
            return View(obj);*/
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
    }
}