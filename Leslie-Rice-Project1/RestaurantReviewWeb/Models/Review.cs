using RestaurantReviewBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantReviewWeb.Models
{
    public class Review
    {
        public int RvId { get; set; }
        public string RestName { get; set; }
        public string RestAddress { get; set; }
        public decimal? RvRating { get; set; }
        public string RvSummary { get; set; }
        //public int FK_RId { get; set; }

        public static List<Review> GetReviews()
        {
            List<Review> lsRev = new List<Review>();
            foreach (var item in RRBusinessLogic.GetAllReviews())
            {
                lsRev.Add((Review)item);
            }
            return lsRev;
        }

        public static explicit operator Review(RestaurantReviewBusinessLayer.Review rrbl)
        {
            Review rv = new Review();
            rv.RestName = rrbl.RestaurantName;
            rv.RestAddress = rrbl.ReviewAddress;
            rv.RvRating = rrbl.Rating;
            rv.RvSummary = rrbl.ReviewSummary;
            return rv;
        }
    }
}