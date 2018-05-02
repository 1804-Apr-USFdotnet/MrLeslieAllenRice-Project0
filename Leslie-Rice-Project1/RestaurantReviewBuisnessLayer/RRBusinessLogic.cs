﻿using System;
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
                Console.WriteLine("Please enter the Restaurant you would like to write a review for");
                string sRestaurantInput = Console.ReadLine();
                Console.WriteLine("Please enter the address of the Restaurant you would like to write a review for");
                string sAddressInput = Console.ReadLine();
                Console.WriteLine("Please enter the rating (out of 5.00) for the Restaurant");
                string sRvRatingInput = Console.ReadLine();
                decimal dRvRatingInput = decimal.Parse(sRvRatingInput);
                Console.WriteLine("Please enter a brief rating summary for the Restaurant");
                string sRatingSummaryInput = Console.ReadLine();
                Console.WriteLine("Please enter the primary key for the Restaurant");
                string sForeignKey = Console.ReadLine();
                int iForeignKey = int.Parse(sForeignKey);

                RestaurantData.InsertReviewIntoDB(sRestaurantInput, sAddressInput, dRvRatingInput,
                    sRatingSummaryInput, iForeignKey);
            }
            else if(_iUserOption == "4")
            {
                Console.WriteLine("Please enter the Restaurant you would like to add");
                string sRestaurantInput = Console.ReadLine();
                Console.WriteLine("Please enter the address of the Restaurant you would like to add");
                string sAddressInput = Console.ReadLine();
                Console.WriteLine("Please enter the rating (out of 5.00) for the Restaurant");
                string sInput = Console.ReadLine();
                decimal dRatingInput = decimal.Parse(sInput);

                RestaurantData.InsertRestaurantIntoDB(sRestaurantInput, sAddressInput, dRatingInput);
            }
            else if(_iUserOption == "5")
            {
                Console.WriteLine("Please enter the Restaurant of the review you would like to delete");
                string sRestaurantInput = Console.ReadLine();
                Console.WriteLine("Please enter the rating summary for the Restaurant review you would like to delete");
                string sRatingSummaryInput = Console.ReadLine();

                RestaurantData.DeleteReviewFromDB(sRestaurantInput, sRatingSummaryInput);
            }
            else if(_iUserOption == "6")
            {
                Console.WriteLine("Please enter the Restaurant you would like to delete");
                string sRestaurantInput = Console.ReadLine();

                RestaurantData.DeleteRestaurantFromDB(sRestaurantInput);
            }
            else if(_iUserOption == "7")
            {
                List<RestaurantDataLayer.Restaurant> lsLocalRestaurants = 
                    RestaurantData.ShowAllRestaurants();
                
                RestaurantSort.DisplayTopThreeRestaurants(lsLocalRestaurants);

                int i = 0;
                foreach (var element in lsLocalRestaurants)
                {
                    if(i < 3)
                    {
                        Console.WriteLine(element.rName);
                        Console.WriteLine("Address: " + element.rAddress);
                        Console.WriteLine("Average Rating: " + element.rAvgRating);
                        i++;
                    }
                    
                }
            }
            else if(_iUserOption == "8")
            {
                List<RestaurantDataLayer.Restaurant> lsLocalRestaurants =
                    RestaurantData.ShowAllRestaurants();

                RestaurantSort.DisplayAllRestaurantsAsc(lsLocalRestaurants);

                foreach(var element in lsLocalRestaurants)
                {
                    Console.WriteLine(element.rName);
                    Console.WriteLine("Address: " + element.rAddress);
                    Console.WriteLine("Average Rating: " + element.rAvgRating);
                }
            }
            else if(_iUserOption == "9")
            {
                List<RestaurantDataLayer.Restaurant> lsLocalRestaurants =
                    RestaurantData.ShowAllRestaurants();

                RestaurantSort.DisplayAllRestaurantDesc(lsLocalRestaurants);

                foreach (var element in lsLocalRestaurants)
                {
                    Console.WriteLine(element.rName);
                    Console.WriteLine("Address: " + element.rAddress);
                    Console.WriteLine("Average Rating: " + element.rAvgRating);
                }
            }
            else if(_iUserOption == "10")
            {
                Console.WriteLine("Please enter the partial string of the restaurant" +
                    " you would like to search:");
                string sPartString = Console.ReadLine();

                List<RestaurantDataLayer.Restaurant> lsRestaurants = 
                    RestaurantData.ShowAllRestaurants();

                List<RestaurantDataLayer.Restaurant> lsReturnRestaurants =
                    RestaurantSearch.DisplayRestaurantsContaining(lsRestaurants, sPartString);

                foreach(var element in lsReturnRestaurants)
                {
                    Console.WriteLine();
                    Console.WriteLine(element.rName);
                    Console.WriteLine("Address: " + element.rAddress);
                    Console.WriteLine("Average rating: " + element.rAvgRating);
                }
            }
        }
    }
}
