using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewBusinessLayer;

namespace TestRestaurantReview
{
    /// <summary>
    /// Summary description for TestSerialization
    /// </summary>
    [TestClass]
    public class TestSerialization
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestSerializeRestaurants()
        {
            // Arrange
            Restaurant test1 = new Restaurant("Arbys", "E Fletcher Ave Tampa Florida 33612", 4.4m);
            Restaurant test2 = new Restaurant("Taco Bell", "5318 E Fowler Ave Tampa Florida 33617", 2.4m);
            Restaurant test3 = new Restaurant("Burger King", "5301 E Fowler Ave Temple Terrace Florida 33617", 3.1m);
            Restaurant test4 = new Restaurant("McDonalds", "11707 N 56th St Tampa Florida 33617", 5.0m);
            Restaurant test5 = new Restaurant("Fazolis", "238 W Alexander St Plant City Florida 33563", 1.4m);
            Restaurant test6 = new Restaurant("Steak n Shake", "1450 E Fowler Ave Temple Terrace Florida 33617", 3.2m);
            Restaurant test7 = new Restaurant("Subway", "4202 E Fowler Ave Tampa Florida 33620", 4.8m);
            Restaurant test8 = new Restaurant("Dunkin Donuts", "5610 E Fowler Ave Temple Terrace Florida 33617", 4.1m);
            Restaurant test9 = new Restaurant("KFC", "2212 E Fowler Ave Tampa Florida 33612", 0.4m);
            Restaurant test10 = new Restaurant("Sonic", "1915 E Fowler Ave Tampa Florida 33612", 1.1m);

            // Act
            List<Restaurant> lsRestaurantList = new List<Restaurant> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };

            // Assert
            SerializerDeserializerHelper.SerializeRestaurants(lsRestaurantList);
        }

        [TestMethod]
        public void TestSerializeReviews()
        {
            // Arrange
            Review test1 = new Review("Arbys", "2010 Somwhere", 4.4m, "The best roast beef sandwich.");
            Review test2 = new Review("Taco Bell", "2010 Somwhere", 2.4m, "Not the best tacos I've ever had.");
            Review test3 = new Review("Burger King", "2010 Somwhere", 3.1m, "The onion rings were over cooked.");
            Review test4 = new Review("McDonalds", "2010 Somwhere", 5.0m, "Value menu is the best!");
            Review test5 = new Review("Fazolis", "2010 Somwhere", 1.4m, "Breadsticks were soggy.");
            Review test6 = new Review("Sonic", "2010 Somwhere", 3.2m, "I wish their happy hour was longer.");
            Review test7 = new Review("Subway", "2010 Somwhere", 4.8m, "My favorite place to eat.");
            Review test8 = new Review("McDonalds", "2010 Somwhere", 4.1m, "They have the best french fries.");
            Review test9 = new Review("KFC", "2010 Somwhere", 0.4m, "The chicken was under cooked.");
            Review test10 = new Review("Sonic", "2010 Somwhere", 1.1m, "Good food...but extremely poor service.");

            // Act
            List<Review> lsRestaurantList = new List<Review> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };

            // Assert
            SerializerDeserializerHelper.SerializeRestaurantReviews(lsRestaurantList);
        }
    }
}
