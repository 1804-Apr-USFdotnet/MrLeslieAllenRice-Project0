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

        public static List<Restaurant> DisplayRestaurantsContaining(string sPartialName,
            List<Restaurant> lsRest)
        {
            List<Restaurant> lsLocalList = new List<Restaurant>();

            for(int i = 0; i < lsRest.Count; i++)
            {
                if(lsRest.ElementAt(i).Name.Contains(sPartialName))
                {
                    lsLocalList.Add(lsRest.ElementAt(i));
                }
            }
            return lsLocalList;
        }
    }
}
