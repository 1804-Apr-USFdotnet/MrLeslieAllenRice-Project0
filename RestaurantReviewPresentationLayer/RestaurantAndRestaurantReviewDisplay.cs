using System;
using System.Collections.Generic;
using RestaurantReviewBuisnessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewPresentationLayer
{
    public class RestaurantReviewDisplay
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("|--------------------Restaurant Reviews Program--------------------|\n");
            Console.WriteLine("1.) Display all restaurants");
            Console.WriteLine("2.) Display all reviews for a restaurant");
            Console.WriteLine("3.) Add a review for a restaurant");
            Console.WriteLine("4.) Add a restaurant");
            Console.WriteLine("5.) Delete a review for a restaurant");
            Console.WriteLine("6.) Delete a restaurant");
            Console.WriteLine("7.) Help menu\n");
            Console.WriteLine("Please enter your selection (1 - 7):");

        }

        public static void DisplayHelpMenu()
        {
            Console.WriteLine("|--------------------Help Menu--------------------|\n");
            Console.WriteLine("Use of the Restaurant Reviews program is quite");
            Console.WriteLine("easy. Simply type the number value of the");
            Console.WriteLine("option that you want to run. Once you have done");
            Console.WriteLine("that, just follow the instructions printed to the");
            Console.WriteLine("console.");
        }

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

        public static void DisplayRestaurantAdded()
        {
            Console.WriteLine("Restaurant was successfully added!");
        }

        public static void DisplayReviewAdded()
        {
            Console.WriteLine("Review was successfully added!");
        }

        public static void DisplayRestaurantRemoved()
        {
            Console.WriteLine("Restaurant was successfully removed!");
        }

        public static void DisplayReviewRemoved()
        {
            Console.WriteLine("Review was successfully removed!");
        }
    }
}
