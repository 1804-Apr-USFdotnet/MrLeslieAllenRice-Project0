using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviewBusinessLayer
{
    public class Review
    {
        private string sRestaurantName;
        private string sReviewAddress;
        private string sReviewSummary;
        private decimal? dRating;
        private int fk_rId;

        public string RestaurantName
        {
            get => sRestaurantName;
            set => sRestaurantName = value;
        }

        public string ReviewAddress
        {
            get => sReviewAddress;
            set => sReviewAddress = value;
        }

        public string ReviewSummary
        {
            get => sReviewSummary;
            set => sReviewSummary = value;
        }

        public decimal? Rating
        {
            get => dRating;
            set => dRating = value;
        }

        public int RId
        {
            get => fk_rId;
            set => fk_rId = value;
        }
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

        public static explicit operator Review(RestaurantDataLayer.Review rdl)
        {
            Review rv = new Review();
            rv.RestaurantName = rdl.rName;
            rv.ReviewAddress = rdl.rAddress;
            rv.Rating = rdl.rRating;
            rv.ReviewSummary = rdl.rSummary;
            return rv;
        }
    }
}
