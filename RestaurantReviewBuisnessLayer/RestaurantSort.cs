using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantReviewBuisnessLayer
{
    public static class RestaurantSort
    {

        public static List<Restaurant> DisplayTopThreeRestaurants(List<Restaurant> lsRestaurants)
        {
            Restaurant_SortTopThreeByRating topThree = new Restaurant_SortTopThreeByRating();
            lsRestaurants.Sort(topThree);

            List<Restaurant> lsTopRestaurants = new List<Restaurant> { lsRestaurants[0], lsRestaurants[1],
            lsRestaurants[2]};

            return lsTopRestaurants;
        }

        public static List<Restaurant> DisplayAllRestaurantsAsc(List<Restaurant> lsRestaurants)
        {
            Restaurant_SortAlphabetical alphabetizedAsc = new Restaurant_SortAlphabetical();
            lsRestaurants.Sort(alphabetizedAsc);

            List<Restaurant> lsRestaurantsInAsc = new List<Restaurant>(lsRestaurants);

            return lsRestaurantsInAsc;
        }

        public static List<Restaurant> DisplayAllRestaurantDesc(List<Restaurant> lsRestaurants)
        {
            Restaurant_SortAlphabetical alphabetizedDesc = new Restaurant_SortAlphabetical();
            lsRestaurants.Sort(alphabetizedDesc);

            List<Restaurant> lsRestaurantsInAsc = new List<Restaurant>(lsRestaurants.Reverse<Restaurant>());

            return lsRestaurantsInAsc;
        }
    }
}
