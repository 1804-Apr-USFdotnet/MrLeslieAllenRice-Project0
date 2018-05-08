using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

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

        public static List<Restaurant> SortAscending(List<Restaurant> lsRestaurants)
        {
            List<Restaurant> lsLocalList = new List<Restaurant>();
            lsLocalList = RestaurantSort.DisplayAllRestaurantsAsc(lsRestaurants);
            return lsLocalList;
        }

        public static List<Restaurant> SortDescending(List<Restaurant> lsRestaurants)
        {
            List<Restaurant> lsLocalList = new List<Restaurant>();
            lsLocalList = RestaurantSort.DisplayAllRestaurantDesc(lsRestaurants);
            return lsLocalList;
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

        public static ClassLibrary1.Restaurant ToDB(Restaurant r)
        {
            ClassLibrary1.Restaurant rest = new ClassLibrary1.Restaurant
            {
                rId = r.Id,
                rName = r.Name,
                rAddress = r.Address,
                rAvgRating = r.AvgRating
            };
            return rest;
        }

        public static ClassLibrary1.Review ReviewToDB(Review r)
        {
            ClassLibrary1.Review rev = new ClassLibrary1.Review
            {
                rvId = r.RvId,
                rName = r.Name,
                rAddress = r.Address,
                rRating = r.Rating,
                rSummary = r.Summary
            };

            return rev;
        }

        public static Restaurant ToBusiness(ClassLibrary1.Restaurant r)
        {
            Restaurant rest = new Restaurant()
            {
                Id = r.rId,
                Name = r.rName,
                Address = r.rAddress,
                AvgRating = r.rAvgRating
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

        public static void InsertRevIntoDB(string sRestName, string sAddress,
            decimal dRating, string sRevSummary, int iFk_RId)
        {
            RestaurantData.InsertReviewIntoDB(sRestName, sAddress, dRating,
                sRevSummary, iFk_RId);
        }

        public static void UpdateRevInDB(string sRestName, string sAddress,
            decimal dRating, string sSummary)
        {
            RestaurantData.UpdateReviewInDB(sRestName, sAddress, dRating,
                sSummary);
        }

        public static void DeleteRevInDB(string sRestName, decimal dRating, string sSummary)
        {
            RestaurantData.DeleteReviewFromDB(sRestName, dRating, sSummary);
        }

        public static int GetRestaurantId(string sRestName)
        {
            int id = RestaurantData.GetRestaurantId(sRestName);
            return id;
        }

        public static void ProgramLogic(string _iUserOption)
        {
            
        }
    }
}
