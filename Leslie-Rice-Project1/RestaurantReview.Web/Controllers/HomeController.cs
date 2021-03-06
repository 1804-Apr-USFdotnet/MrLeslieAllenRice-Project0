﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReview.Web.Controllers
{
    public class HomeController : Controller
    {
        string name = "Leslie Rice";
        int num = 10;

        //Action Methods
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public string Welcome()
        {
            return "Welcome to <b> USF-Revature</b>";
        }
        //[NonAction]
        public ContentResult Test()
        {
            return Content(HttpUtility.HtmlEncode("This is the .Net <script>alert('Your System is Hacked')</script> Training program"));
        }
        public ActionResult Index()
        {
            TempData["Training"] = ".Net Full Stack";
            return View();
        }
        public ActionResult TestIndex()
        {
            TempData.Keep("Training");
            return View();
        }
    }
}