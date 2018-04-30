using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviewBuisnessLayer
{
    public class Review
    {
        public string sRestaurantName;
        public string sReviewAddress;
        public string sReviewSummary;
        public decimal dRating;

        public Review()
        {
            sRestaurantName = null;
            sReviewAddress = null;
            dRating = 0.0m;
            sReviewSummary = null;
        }

        public Review(string _sRestaurantName, string _sReviewAddress, decimal _dRating,
                                    string _sReviewSummary)
        {
            sRestaurantName = _sRestaurantName;
            sReviewAddress = _sReviewAddress;
            dRating = _dRating;
            sReviewSummary = _sReviewSummary;
        }
    }
}
