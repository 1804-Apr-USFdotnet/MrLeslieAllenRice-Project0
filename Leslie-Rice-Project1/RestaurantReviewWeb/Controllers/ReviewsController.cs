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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string sRestName, string sAddress,
            decimal dRating, string sRevSummary, int iFk_RId)
        {
            Review.InsertRevIntoDB(sRestName, sAddress, dRating, sRevSummary, iFk_RId);
            TempData["rName"] = sRestName;
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Update(string sRestName, string sAddress,
            decimal dRating, string sSummary)
        {
            Review.UpdateRevInDB(sRestName, sAddress, dRating, sSummary);
            return View();
        }

        public ActionResult Remove()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string sRestName, decimal dRating, string sSummary)
        {
            Review.DeleteRevInDB(sRestName, dRating, sSummary);
            return View();
        }

    }
}