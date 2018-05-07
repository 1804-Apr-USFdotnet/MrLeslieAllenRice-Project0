using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantReviewBusinessLayer
{
    public static class RestaurantSort
    {

        public static List<Restaurant> DisplayTopThreeRestaurants()
        {
            int topThree = 3;
            List<Restaurant> lsRest = new List<Restaurant>();

            // Converting restaurant list from data to business
            foreach (var item in RRBusinessLogic.GetAllRestaurants())
            {
                lsRest.Add((Restaurant)item);
            }
            lsRest = (from restaurant in lsRest
                 orderby restaurant.AvgRating descending
                 select restaurant).Take(topThree).ToList();

            return lsRest;
        }

        public static List<Restaurant> DisplayAllRestaurantsAsc
            (List<Restaurant> lsRestaurants)
        {
            List<Restaurant> lsRest = new List<Restaurant>();

            foreach(var item in RRBusinessLogic.GetAllRestaurants())
            {
                lsRest.Add((Restaurant)item);
            }
            lsRest =  (from restaurant in lsRest
                      orderby restaurant.Name ascending
                      select restaurant).ToList();

            return lsRest;
        }

        public static List<Restaurant> DisplayAllRestaurantDesc
            (List<Restaurant> lsRestaurants)
        {
            List<Restaurant> lsRest = new List<Restaurant>();

            foreach (var item in RRBusinessLogic.GetAllRestaurants())
            {
                lsRest.Add((Restaurant)item);
            }
            lsRest = (from restaurant in lsRest
                      orderby restaurant.Name descending
                      select restaurant).ToList();

            return lsRest;
        }
    }
}
