using System;

using System.Collections.Generic;

namespace RestaurantReviewBuisnessLayer
{
    public class Restaurant
    {
        List<Review> lsRestaurantReview;

        public string sName;
        public string sAddress;
        public decimal dAvgRating;

        public Restaurant()
        {
            sName = null;
            sAddress = null;
            dAvgRating = 0.0m;
            lsRestaurantReview = new List<Review>();
        }

        public Restaurant(string _sName, string _sAddress, decimal _dAvgRating)
        {
            this.sName = _sName;
            this.sAddress = _sAddress;
            this.dAvgRating = _dAvgRating;
            lsRestaurantReview = new List<Review>();
        }

        public void addReview(Review rr)
        {
            lsRestaurantReview.Add(rr);
            calcAverageRating();
        }

        private void calcAverageRating()
        {
            decimal total = 0;
            decimal noOfReviews = 0;
            foreach(Review rr in lsRestaurantReview)
            {
                noOfReviews++;
                total += rr.dRating;
            }

            dAvgRating = total / noOfReviews;
        }

        
    }
}
