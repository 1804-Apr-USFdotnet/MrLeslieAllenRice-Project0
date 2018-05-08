using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurantReviewBusinessLayer;

namespace RestaurantReviewWeb.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal? AvgRating { get; set; }
        public List<Review> reviews { get; set; }

        public static List<Restaurant> GetRestaurants()
        {
            List<Restaurant> lsRest = new List<Restaurant>();
            foreach (var item in RRBusinessLogic.GetAllRestaurants())
            {
                lsRest.Add((Restaurant)item);
            }
            return lsRest;
        }
        
        public static List<Restaurant> GetTopThreeRestaurants()
        {
            List<Restaurant> lsRest = new List<Restaurant>();
            foreach(var item in RRBusinessLogic.GetTopThreeRestaurants())
            {
                item.calcAverageRating();
                lsRest.Add((Restaurant)item);
            }
            return lsRest;
        }

        public static List<Restaurant> SortAscending(List<Restaurant> lsRestaurants)
        {
            List<Restaurant> lsRest = new List<Restaurant>();
            lsRestaurants = GetRestaurants();
            foreach (var item in RRBusinessLogic.SortAscending(ToBL(lsRestaurants)))
            {
                lsRest.Add((Restaurant)item);
            }
            return lsRest;
        }

        public static List<Restaurant> SortDescending(List<Restaurant> lsRestaurants)
        {
            List<Restaurant> lsRest = new List<Restaurant>();
            lsRestaurants = GetRestaurants();
            foreach (var item in RRBusinessLogic.SortDescending(ToBL(lsRestaurants)))
            {
                lsRest.Add((Restaurant)item);
            }
            return lsRest;
        }

        public static List<Restaurant> GetRestaurantsContaining(string sRestName)
        {
            List<Restaurant> lsRest = new List<Restaurant>();
            foreach (var item in RRBusinessLogic.SearchRestContaining(sRestName))
            {
                lsRest.Add((Restaurant)item);
            }
            return lsRest;
        }

        public static List<Review> GetReviewsForRestaurant(string sRestName)
        {
            List<Review> lsRest = new List<Review>();
            foreach (var item in RRBusinessLogic.GetReviewsForRestaurant(sRestName))
            {
                lsRest.Add((Review)item);
            }
            return lsRest;
        }

        public static void AddRestaurant(string sRestName, string sAddress)
        {
            RRBusinessLogic.InsertRestIntoDB(sRestName, sAddress);
        }

        public static void DeleteRestaurant(string sRestName)
        {
            RRBusinessLogic.DeleteRestInDB(sRestName);
        }

        public static void UpdateRestaurant(string sRestName, string sAddress)
        {
            RRBusinessLogic.UpdateRestInDB(sRestName, sAddress);
        }

        private static List<RestaurantReviewBusinessLayer.Restaurant> ToBL
            (List<Restaurant> r)
        {
            var rrbl = new List<RestaurantReviewBusinessLayer.Restaurant>();
               foreach(var item in r)
            {
                rrbl.Add(ToData(item));
            }
            return rrbl;
        }

        private static List<Restaurant> ToWebList(List<RestaurantReviewBusinessLayer.Restaurant> r)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            foreach (var element in r)
            {
                restaurants.Add(ToWeb(element));
            }
            return restaurants;
        }

        private static Restaurant ToWeb(RestaurantReviewBusinessLayer.Restaurant rest)
        {
            Restaurant r = new Restaurant
            {
                Id = rest.Id,
                Name = rest.Name,
                Address = rest.Address,
                AvgRating = rest.AvgRating,
            };
            return r;
        }

        public static RestaurantReviewBusinessLayer.Restaurant ToData(Restaurant webRestaurant)
        {
            var dataRestaurant = new RestaurantReviewBusinessLayer.Restaurant()
            {
                Id = webRestaurant.Id,
                Name = webRestaurant.Name,
                Address = webRestaurant.Address
            };
            return dataRestaurant;
        }

        public static explicit operator Restaurant(RestaurantReviewBusinessLayer.Restaurant rrbl)
        {
            Restaurant r = new Restaurant();
            r.Name = rrbl.Name;
            r.Address = rrbl.Address;
            r.AvgRating = rrbl.AvgRating;
            return r;
        }
    }
}