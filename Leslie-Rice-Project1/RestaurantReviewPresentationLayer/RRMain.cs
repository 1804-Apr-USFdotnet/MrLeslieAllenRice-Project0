using System;
using System.Collections.Generic;
using RestaurantReviewBusinessLayer;

namespace RestaurantReviewPresentationLayer
{
    class RRMain
    {
        static void Main(string[] args)
        {
            string rest = "Popeyes";
            string address = "8745 Maple St. Tampa Florida 33601";


            RRBusinessLogic.DeleteRestInDB(rest, address);
            List<Restaurant> r = RRBusinessLogic.GetAllRestaurants();
            foreach(var element in r)
            {
                Console.WriteLine(element.Name);
                Console.WriteLine(element.Address);
                Console.WriteLine(element.AvgRating);
            }
            Console.Read();
        }
    }
}