using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBuisnessLayer
{
    class Restaurant_SortAlphabetical : IComparer<RestaurantDataLayer.Restaurant>
    {
        #region IComparer<Restaurant> Members
        public int Compare(RestaurantDataLayer.Restaurant r1, RestaurantDataLayer.Restaurant r2)
        {
            return string.Compare(r1.rName, r2.rName);
        }
        #endregion
    }

    class Restaurant_Alphabetical : IComparer<Restaurant>
    {
        #region IComparer<Restaurant> Members
        public int Compare(Restaurant r1, Restaurant r2)
        {
            return string.Compare(r1.sName, r2.sName);
        }
        #endregion
    }
}
