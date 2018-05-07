using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantReviewWeb.Models;

namespace RestaurantReviewWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Restaurant> lsRest = Restaurant.GetTopThreeRestaurants();
            return View(lsRest);
        }

        //public ActionResult Restaurants()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    List<Restaurant> lsRest = Restaurant.GetRestaurants();
        //    return View(lsRest);
        //}

        //public ActionResult Reviews()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}