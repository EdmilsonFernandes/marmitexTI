using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TI Delivery Marmitex ED software";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre contato com conosco";

            return View();
        }
    }
}