using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDataLayer;

namespace RestaurantReviewBuisnessLayer
{
    public static class RRBusinessLogic
    {
        public static void ProgramLogic(string _iUserOption)
        {
            if(_iUserOption == "1")
            {
                List<RestaurantDataLayer.Restaurant> lsRestaurants = RestaurantData.ShowAllRestaurants();

                foreach(var element in lsRestaurants)
                {
                    Console.WriteLine("");
                    Console.WriteLine(element.rName);
                    Console.WriteLine("Address: " + element.rAddress);
                    Console.WriteLine("Average rating: " + element.rAvgRating);
                }
            }
            else if(_iUserOption == "2")
            {
                Console.WriteLine("Please enter the Restaurant you would like to see reviews for");
                string sUserInput = Console.ReadLine();
                List<RestaurantDataLayer.Review> lsReviews = RestaurantData.ShowRestaurantReviews(sUserInput);

               foreach(var element in lsReviews)
                {
                    Console.WriteLine("");
                    Console.WriteLine(element.rName);
                    Console.WriteLine("Address: " + element.rAddress);
                    Console.WriteLine("Average rating: " + element.rRating);
                    Console.WriteLine("Review summary: " + element.rSummary);
                }
                Console.WriteLine();
            }
            else if(_iUserOption == "3")
            {

            }
            else if(_iUserOption == "4")
            {

            }
            else if(_iUserOption == "5")
            {

            }
            else if(_iUserOption == "6")
            {

            }
            else
            {

            }
        }

        public static void DisplayRestaurantDetails(Restaurant r)
        {
            Console.WriteLine(r.sName);
            Console.WriteLine("Address: " + r.sAddress);
            Console.WriteLine("Average rating: " + r.dAvgRating);
        }
    }
}
