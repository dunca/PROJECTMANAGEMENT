using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Author = "Flaviu";

            var model = new AboutModel() { Author = "Flaviu", Message = "Hello" };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public double CalcAverage()
        {
            var list = new List<int>() { 1, 3, 7 };
            //return list.Average();

            double sum = 0;
            foreach (var x in list)
            {
                sum += x;
            }

            return sum / list.Count;
        }
    }
}