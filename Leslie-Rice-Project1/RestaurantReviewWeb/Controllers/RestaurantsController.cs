using RestaurantReviewWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviewWeb.Controllers
{
    public class RestaurantsController : Controller
    {
        public ActionResult Index()
        {
            List<Restaurant> lsRest = Restaurant.GetRestaurants();
            return View(lsRest);
        }

        [HttpPost]
        public ActionResult Search(string sSearch)
        {
            List<Restaurant> lsRest = Restaurant.GetRestaurantsContaining(sSearch);
            return View(lsRest);
        }

        // GET: Restaurant
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string sRestName, string sAddress)
        {
            Restaurant.AddRestaurant(sRestName, sAddress);
            return View();
        }

        public ActionResult Delete(string sRestName)
        {
            Restaurant.DeleteRestaurant(sRestName);
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Update(string sRestName, string sAddress)
        {
            Restaurant.UpdateRestaurant(sRestName, sAddress);
            return View();
        }
    }
}