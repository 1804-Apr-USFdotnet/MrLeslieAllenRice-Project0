using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDataLayer;

namespace RestaurantReviewBusinessLayer
{
    public static class RRBusinessLogic
    {
        public static List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> lsRestaurants = new List<Restaurant>();
            foreach(var item in RestaurantData.ShowAllRestaurants())
            {
                lsRestaurants.Add((Restaurant)item);
            }
            return lsRestaurants;
        }

        public static List<Review> GetAllReviews()
        {
            List<Review> lsReviews = new List<Review>();
            foreach(var item in RestaurantData.ShowAllReviews())
            {
                lsReviews.Add((Review)item);
            }

            return lsReviews;
        }

        public static List<Restaurant> SearchRestContaining(string sRestName)
        {
            List<Restaurant> lsRest = new List<Restaurant>();
            lsRest = RestaurantSearch.DisplayRestaurantsContaining(sRestName);
            return lsRest;
        }

        public static List<Review> GetReviewsForRestaurant(string sRestName)
        {
            List<Review> lsLocalList = new List<Review>();
            foreach (var item in RestaurantData.ShowReviewsForRestaurant(sRestName))
            {
                lsLocalList.Add((Review)item);
            }

            return lsLocalList;
        }

        public static RestaurantDataLayer.Restaurant ToDB(Restaurant r)
        {
            RestaurantDataLayer.Restaurant rest = new RestaurantDataLayer.Restaurant
            {
                rId = r.Id,
                rName = r.Name,
                rAddress = r.Address,
                rAvgRating = r.AvgRating
            };
            return rest;
        }

        public static List<Restaurant> GetTopThreeRestaurants()
        {
            List<Restaurant> lsTopThree;
            lsTopThree = RestaurantSort.DisplayTopThreeRestaurants();
            return lsTopThree;
        }

        public static void InsertRestIntoDB(string sRestName, string sAddress)
        {
            RestaurantData.InsertRestaurantIntoDB(sRestName, sAddress);
        }

        public static void DeleteRestInDB(string sRestName)
        {
            RestaurantData.DeleteRestaurantFromDB(sRestName);
        }

        public static void UpdateRestInDB(string sRestName, string sAddress)
        {
            RestaurantData.UpdateRestaurantInDB(sRestName, sAddress);
        }

        //public static int InsertRevIntoDB()
        //{

        //}



        public static void UpdateRevInDB()
        {

        }

        public static void DeleteRevInDB()
        {

        }

        public static void ProgramLogic(string _iUserOption)
        {
            
        }
    }
}
