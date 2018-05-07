using System;
using System.Collections.Generic;
using RestaurantReviewBusinessLayer;

namespace RestaurantReview.Web.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Review reviews { get; set; }

        public void GetRestaurants()
        {
            RRBusinessLogic.
        }

        public void GetRestaurantReviews()
        {

        }

        public void AddRestaurant()
        {
            // Add logic here
        }

        public void AddReview()
        {

        }

        public void UpdateRestaurant()
        {

        }

        public void UpdateReview()
        {

        }

        public void DeleteRestaurant()
        {

        }

        public void DeleteReview()
        {

        }



        public static Restaurant ToWeb(RestaurantReview.Web.Models.Restaurant dataRestaurant)
        {
            var webRestaurant = new Restaurant()
            {
                Id = dataRestaurant.Id,
                Name = dataRestaurant.Name,
                Address = dataRestaurant.Address
            };

            return webRestaurant;
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
    }
}