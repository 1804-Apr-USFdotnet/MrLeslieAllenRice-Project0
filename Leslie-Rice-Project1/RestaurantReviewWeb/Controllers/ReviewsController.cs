using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantReviewWeb.Models;

namespace RestaurantReviewWeb.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Review
        public ActionResult Index()
        {
            List<Review> lsReview = Review.GetReviews();
            return View(lsReview);
        }

        public ActionResult Search(string sRestName, string sAddress)
        {
            List<Review> lsRev = Restaurant.GetReviewsForRestaurant(sRestName);
            TempData["rName"] = sRestName;
            TempData["rAddress"] = sAddress;
            return View(lsRev);
        }

    }
}