using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBuisnessLayer 
{
    class Restaurant_SortTopThreeByRating : IComparer<RestaurantDataLayer.Restaurant>
    {
        #region IComparer<Restaurant> Members
        public int Compare(RestaurantDataLayer.Restaurant r1, RestaurantDataLayer.Restaurant r2)
        {
            if(r1.rAvgRating < r2.rAvgRating)
            {
                return 1;
            }
            else if(r1.rAvgRating > r2.rAvgRating)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }

    class Restaurant_TopThreeByRating : IComparer<Restaurant>
    {
        #region IComparer<Restaurant> Members
        public int Compare(Restaurant r1, Restaurant r2)
        {
            if (r1.dAvgRating < r2.dAvgRating)
            {
                return 1;
            }
            else if (r1.dAvgRating > r2.dAvgRating)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
