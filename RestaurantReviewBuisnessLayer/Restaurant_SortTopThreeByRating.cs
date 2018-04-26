using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBuisnessLayer 
{
    class Restaurant_SortTopThreeByRating : IComparer<Restaurant>
    {
        #region IComparer<Restaurant> Members
        public int Compare(Restaurant r1, Restaurant r2)
        {
            if(r1.dAvgRating < r2.dAvgRating)
            {
                return 1;
            }
            else if(r1.dAvgRating > r2.dAvgRating)
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
