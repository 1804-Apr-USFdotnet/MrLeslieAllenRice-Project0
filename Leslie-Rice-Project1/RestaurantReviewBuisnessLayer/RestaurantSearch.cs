using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBuisnessLayer
{
    public static class RestaurantSearch
    {
        public static List<RestaurantDataLayer.Restaurant> DisplayRestaurantsContaining
            (List<RestaurantDataLayer.Restaurant> r, string _sPartialName)
        {
            List<RestaurantDataLayer.Restaurant> containingRestaurant = 
                new List<RestaurantDataLayer.Restaurant>();

            for (int i = 0; i < r.Count; i++)
            {
                if (r.ElementAt(i).rName.Contains(_sPartialName))
                {
                    containingRestaurant.Add(r.ElementAt(i));
                }
            }

            return containingRestaurant;
        }

        public static List<Restaurant> DisplayRestaurantsContaining(List<Restaurant> r, string _sPartialName)
        {
            List<Restaurant> containingRestaurant = new List<Restaurant>();

            for(int i = 0; i < r.Count; i++)
            {
                if(r.ElementAt(i).sName.Contains(_sPartialName))
                {
                    containingRestaurant.Add(r.ElementAt(i));
                }
            }

            return containingRestaurant;
        }
    }
}
