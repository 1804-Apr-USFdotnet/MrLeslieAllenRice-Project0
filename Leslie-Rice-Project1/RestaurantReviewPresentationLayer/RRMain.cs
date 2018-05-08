using System;
using System.Collections.Generic;
using RestaurantReviewBusinessLayer;

namespace RestaurantReviewPresentationLayer
{
    class RRMain
    {
        static void Main(string[] args)
        {
            List<Restaurant> lsRest = RRBusinessLogic.GetAllRestaurants();
            foreach(var item in lsRest)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }

            string rest = "Wendys";
            RRBusinessLogic.DeleteRestInDB(rest);

            Console.WriteLine("after delete");

            foreach(var item in lsRest)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}