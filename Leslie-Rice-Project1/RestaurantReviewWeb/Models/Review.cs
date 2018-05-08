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

        public static List<Review> GetReviews()
        {
            List<Review> lsRev = new List<Review>();
            foreach (var item in RRBusinessLogic.GetAllReviews())
            {
                lsRev.Add((Review)item);
            }
            return lsRev;
        }
        public static void InsertRevIntoDB(string sRestName, string sAddress,
            decimal dRating, string sRevSummary, int iFk_RId)
        {
            RRBusinessLogic.InsertRevIntoDB(sRestName, sAddress, dRating,
                sRevSummary, iFk_RId);
        }

        public static void UpdateRevInDB(string sRestName, string sAddress,
            decimal dRating, string sSummary)
        {
            RRBusinessLogic.UpdateRevInDB(sRestName, sAddress, dRating,
                sSummary);
        }

        public static void DeleteRevInDB(string sRestName, decimal dRating, string sSummary)
        {
            RRBusinessLogic.DeleteRevInDB(sRestName, dRating, sSummary);
        }

        public static RestaurantReviewBusinessLayer.Review ReviewToBL(Review r)
        {
            RestaurantReviewBusinessLayer.Review rev = new RestaurantReviewBusinessLayer.Review
            {
                RvId = r.RvId,
                Name = r.RestName,
                Address = r.RestAddress,
                Rating = r.RvRating,
                Summary = r.RvSummary
            };

            return rev;
        }

        public static explicit operator Review(RestaurantReviewBusinessLayer.Review rrbl)
        {
            Review rv = new Review();
            rv.RestName = rrbl.Name;
            rv.RestAddress = rrbl.Address;
            rv.RvRating = rrbl.Rating;
            rv.RvSummary = rrbl.Summary;
            return rv;
        }
    }
}