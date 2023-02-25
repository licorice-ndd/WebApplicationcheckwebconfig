using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationcheckwebconfig.Models;

namespace WebApplicationcheckwebconfig.Controllers
{
    public class CoffeesController : Controller
    {
        // GET: Coffees
        public ActionResult Index()
        {
            ListCoffee strLC = new ListCoffee();
            List<QuanLyCoffee> obj = strLC.getCoffee(string.Empty);
            return View(obj);
        }
    }
}