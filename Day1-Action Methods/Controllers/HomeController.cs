using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionMthodsInMVC.Models;
using Newtonsoft.Json;

namespace ActionMthodsInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Show()
        {
            return "This is second action method of home controller";
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public int StudentId(int id)
        {
            return id;
        }

        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult Content()
        {
            return Content("This is content I want to display");
        }

        public ActionResult RedirectToExternalURL()
        {
            return Redirect("https://www.youtube.com/watch?v=S4HXcK32Ilw");

        }

        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        public ActionResult RedirectToAction()
        {
            return RedirectToAction("Index", "Home");
        }


        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "Test",
                email = "Test@123"
            };

            var json = JsonConvert.SerializeObject(std);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}