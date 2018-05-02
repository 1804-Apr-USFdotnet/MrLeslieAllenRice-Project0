using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantReviewBuisnessLayer
{
    public static class RestaurantSort
    {

        public static List<RestaurantDataLayer.Restaurant> DisplayTopThreeRestaurants
            (List<RestaurantDataLayer.Restaurant> lsRestaurants)
        {
            Restaurant_SortTopThreeByRating topThree = 
                new Restaurant_SortTopThreeByRating();

            lsRestaurants.Sort(topThree);

            List<RestaurantDataLayer.Restaurant> lsTopRestaurants = 
                new List<RestaurantDataLayer.Restaurant>()
            { lsRestaurants.ElementAt(0), lsRestaurants.ElementAt(1), lsRestaurants.ElementAt(2)};

            return lsTopRestaurants;
        }

        public static List<Restaurant> DisplayTopThreeRestaurants
            (List<Restaurant> lsRestaurants)
        {
            Restaurant_TopThreeByRating topThree =
                new Restaurant_TopThreeByRating();

            lsRestaurants.Sort(topThree);

            List<Restaurant> lsTopRestaurants = new List<Restaurant>()
            { lsRestaurants[0], lsRestaurants[1], lsRestaurants[2] };

            return lsTopRestaurants;
        }

        public static List<RestaurantDataLayer.Restaurant> DisplayAllRestaurantsAsc
            (List<RestaurantDataLayer.Restaurant> lsRestaurants)
        {
            Restaurant_SortAlphabetical alphabetizedAsc = 
                new Restaurant_SortAlphabetical();

            lsRestaurants.Sort(alphabetizedAsc);

            List<RestaurantDataLayer.Restaurant> lsRestaurantsInAsc = 
                new List<RestaurantDataLayer.Restaurant>(lsRestaurants);

            return lsRestaurantsInAsc;
        }

        public static List<Restaurant> DisplayAllRestaurantsAsc
            (List<Restaurant> lsRestaurants)
        {
            Restaurant_Alphabetical alphabetizedAsc =
                new Restaurant_Alphabetical();

            lsRestaurants.Sort(alphabetizedAsc);

            List<Restaurant> lsRestaurantsInAsc = new List<Restaurant>(lsRestaurants);

            return lsRestaurantsInAsc;
        }

        public static List<RestaurantDataLayer.Restaurant> DisplayAllRestaurantDesc
            (List<RestaurantDataLayer.Restaurant> lsRestaurants)
        {
            Restaurant_SortAlphabetical alphabetizedDesc = 
                new Restaurant_SortAlphabetical();

            lsRestaurants.Sort(alphabetizedDesc);

            List<RestaurantDataLayer.Restaurant> lsRestaurantsInAsc = 
                new List<RestaurantDataLayer.Restaurant>
                (lsRestaurants.Reverse<RestaurantDataLayer.Restaurant>());

            return lsRestaurantsInAsc;
        }

        public static List<Restaurant> DisplayAllRestaurantDesc
            (List<Restaurant> lsRestaurants)
        {
            Restaurant_Alphabetical alphabetizedDesc =
                new Restaurant_Alphabetical();

            lsRestaurants.Sort(alphabetizedDesc);

            List<Restaurant> lsRestaurantsInAsc =
                new List<Restaurant>(lsRestaurants.Reverse<Restaurant>());

            return lsRestaurantsInAsc;
        }
    }
}
