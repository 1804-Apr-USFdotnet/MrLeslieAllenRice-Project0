using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviewBusinessLayer
{
    public class Review
    {
        private int rvId;
        private string rName;
        private string rAddress;
        private decimal? rRating;
        private string rSummary;
        private int fk_rId;

        public int RvId
        {
            get => rvId;
            set => rvId = value;
        }

        public string Name
        {
            get => rName;
            set => rName = value;
        }

        public string Address
        {
            get => rAddress;
            set => rAddress = value;
        }

        public decimal? Rating
        {
            get => rRating;
            set => rRating = value;
        }

        public string Summary
        {
            get => rSummary;
            set => rSummary = value;
        }

        public int RId
        {
            get => fk_rId;
            set => fk_rId = value;
        }

        public Review()
        {
            Name = null;
            Address = null;
            Rating = 0.0m;
            Summary = null;
        }

        public Review(string _sRestaurantName, string _sReviewAddress, decimal _dRating,
                                    string _sReviewSummary)
        {
            Name = _sRestaurantName;
            Address = _sReviewAddress;
            Summary = _sReviewSummary;
            Rating = _dRating;
        }

        public static explicit operator Review(RestaurantDataLayer.Review rdl)
        {
            Review rv = new Review();
            rv.Name = rdl.rName;
            rv.Address = rdl.rAddress;
            rv.Rating = rdl.rRating;
            rv.Summary = rdl.rSummary;
            return rv;
        }
    }
}
