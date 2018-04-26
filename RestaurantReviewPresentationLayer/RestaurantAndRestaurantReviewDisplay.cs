using System;
using System.Collections.Generic;
using RestaurantReviewBuisnessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewPresentationLayer
{
    public static class RestaurantAndRestaurantReviewDisplay
    {
        public static void DisplayRestaurantDetails(Restaurant r)
        {
            Console.WriteLine(r.sName);
            Console.WriteLine("Address: " + r.sAddress);
            Console.WriteLine("Average rating: " + r.dAvgRating);
        }

        public static void DisplayReviewsForRestaurant(List<Review> rr)
        {
            foreach(Review r in rr)
            {
                Console.WriteLine(r.sRestaurantName);
                Console.WriteLine("Review: " + r.sReviewSummary);
                Console.WriteLine("Rating: " + r.dRating);
            }
        }
    }
}
