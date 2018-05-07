using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDataLayer;

namespace RestaurantReviewBusinessLayer
{
    public static class RestaurantSearch
    {
        public static List<Restaurant> DisplayRestaurantsContaining(string _sPartialName)
        {
            List<Restaurant> lsLocalList = new List<Restaurant>();
            
            foreach (var item in RestaurantData.ShowAllRestaurants())
            {
                lsLocalList.Add((Restaurant)item);
            }
            
            List<Restaurant> containingRestaurant = new List<Restaurant>();

            for (int i = 0; i < lsLocalList.Count; i++)
            {
                if (lsLocalList.ElementAt(i).Name.Contains(_sPartialName))
                {
                    containingRestaurant.Add(lsLocalList.ElementAt(i));
                }
            }

            return containingRestaurant;
        }
    }
}
