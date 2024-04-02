using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterMVC.Controllers
{
    public class HomeController : Controller
    {
        [HandleError(View="Error")]
        public ActionResult Index()
        {
            throw new Exception();
            return View();

        }
        [HandleError(View = "Error2")]
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }


        //public ActionResult Index()
        //{
        //Divide by zero exception
        //int a = 10;
        //int b = 0;
        //int c = a / b;

        //Null refrence exception
        //string a = null;
        //int b = a.Length;

        //Index out of range exception
        //int[] a = new int[3];
        //a[0] = 1;
        //a[1] = 2;
        //a[2] = 3;
        //a[3] = 4;

        //try
        //{
        //    throw new Exception();
        //}
        //catch (Exception ex)
        //{ 
        //    return RedirectToAction("ErrorPage", "Home");
        //}

        //    return view();
        //}




        //public ActionResult ErrorPage()
        //{ 
        //     return View();
        //}

    }
}