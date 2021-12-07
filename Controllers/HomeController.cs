using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_3.Models;

namespace Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult RegisterNow()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegisterNow(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
        public ActionResult Index()
        {
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