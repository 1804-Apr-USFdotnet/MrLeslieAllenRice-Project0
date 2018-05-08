using System;
using RestaurantDataLayer;

using System.Collections.Generic;
using System.Linq;
using RestaurantDataLayer;

namespace RestaurantReviewBusinessLayer
{
    public class Restaurant
    {
        List<Review> lsRestaurantReview;

        private int iId;
        private string sName;
        private string sAddress;
        private decimal? dAvgRating;

        public int Id
        {
            get => iId;
            set => iId = value;
        }

        public string Name
        {
            get => sName;
            set => sName = value;
        }

        public string Address
        {
            get => sAddress;
            set => sAddress = value;
        }

        public decimal? AvgRating
        {
            get => dAvgRating;
            set => dAvgRating = value;
        }
        

        public Restaurant()
        {
            sName = null;
            sAddress = null;
            dAvgRating = 0.0m;
            lsRestaurantReview = new List<Review>();
            calcAverageRating();
        }

        public Restaurant(string _sName, string _sAddress, decimal _dAvgRating)
        {
            sName = _sName;
            sAddress = _sAddress;
            dAvgRating = _dAvgRating;
            lsRestaurantReview = new List<Review>();
            calcAverageRating();
        }

        public void addReview(Review rr)
        {
            lsRestaurantReview.Add(rr);
            calcAverageRating();
        }

        public void calcAverageRating()
        {
            decimal? total = 0;
            decimal noOfReviews = 0;
            foreach(Review rr in lsRestaurantReview)
            {
                noOfReviews++;
                total += rr.Rating;
            }
            if (noOfReviews > 0)
            {
                dAvgRating = total / noOfReviews;
            }
            else
                dAvgRating = 0.0m;
            
        }

        public static explicit operator Restaurant(RestaurantDataLayer.Restaurant rdl)
        {
            Restaurant r = new Restaurant();
            r.Name = rdl.rName;
            r.Address = rdl.rAddress;
            foreach(var item in rdl.Reviews)
            {
                r.lsRestaurantReview.Add((Review)item);
            }
            r.calcAverageRating();
            return r;
        }

        
    }
}
