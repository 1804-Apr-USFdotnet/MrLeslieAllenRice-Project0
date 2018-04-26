using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviewBuisnessLayer
{
    public class Review
    {
        public string sRestaurantName;
        public string sReviewSummary;
        public double dRating;

        public Review()
        {
            sRestaurantName = null;
            sReviewSummary = null;
            dRating = 0.0;
        }

        public Review(string _sRestaurantName, string _sReviewSummary,
                                   double _dRating)
        {
            sRestaurantName = _sRestaurantName;
            sReviewSummary = _sReviewSummary;
            dRating = _dRating;
        }
    }
}
