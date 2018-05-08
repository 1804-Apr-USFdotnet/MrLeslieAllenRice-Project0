using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewBusinessLayer;

namespace RestaurantReviewBusinessLogicTest
{
    /// <summary>
    /// Summary description for TestRestaurantSearch
    /// </summary>
    [TestClass]
    public class TestRestaurantSearch
    {

        [TestMethod]
        public void TestDisplayRestaurantsContaining()
        {
            // Arrange
            string sPartName = "Don";
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

            List<Restaurant> lsExpectedList = new List<Restaurant> { test4, test8 };

            // Act
            List<Restaurant> lsTestList = new List<Restaurant> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };
            List<Restaurant> lsActualList = RestaurantSearch.DisplayRestaurantsContaining(sPartName, lsTestList);
            
            // Assert
            CollectionAssert.AreEqual(lsExpectedList, lsActualList);
        }
    }
}
