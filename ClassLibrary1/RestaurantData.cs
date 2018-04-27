using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLayer
{
    public class RestaurantData
    {
        // method to get restaurants
        public List<Restaurant> ShowAllRestaurants()
        {
            List<Restaurant> localList = new List<Restaurant>();

            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
                localList = db.Restaurants.ToList();
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
            }
            catch(SystemException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
            return localList;
        }

        // method to get reviews
        public Restaurant ShowRestaurantReviews(string _sRestaurant)
        {
            Restaurant localRestaurant = new Restaurant();

            RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
            localRestaurant = db.Restaurants.ToList().SingleOrDefault(x => x.rName ==_sRestaurant);

            return localRestaurant;

        }
    }
}
