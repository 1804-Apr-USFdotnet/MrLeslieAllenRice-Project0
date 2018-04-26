using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewBuisnessLayer;

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
            // Act
            string sPartName = "Don";
            Restaurant test1 = new Restaurant("Arbys", "2010 Somwhere", 4.4);
            Restaurant test2 = new Restaurant("Taco Bell", "2010 Somwhere", 2.4);
            Restaurant test3 = new Restaurant("Burger King", "2010 Somwhere", 3.1);
            Restaurant test4 = new Restaurant("McDonalds", "2010 Somwhere", 5.0);
            Restaurant test5 = new Restaurant("Fazolis", "2010 Somwhere", 1.4);
            Restaurant test6 = new Restaurant("Steak n Shake", "2010 Somwhere", 3.2);
            Restaurant test7 = new Restaurant("Subway", "2010 Somwhere", 4.8);
            Restaurant test8 = new Restaurant("Dunkin Donuts", "2010 Somwhere", 4.1);
            Restaurant test9 = new Restaurant("KFC", "2010 Somwhere", 0.4);
            Restaurant test10 = new Restaurant("Sonic", "2010 Somwhere", 1.1);

            List<Restaurant> lsExpectedList = new List<Restaurant> { test4, test8 };

            // Arrange
            List<Restaurant> lsTestList = new List<Restaurant> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };
            List<Restaurant> lsActualList = RestaurantSearch.DisplayRestaurantsContaining(lsTestList,
                sPartName);

            // Assert
            CollectionAssert.AreEqual(lsExpectedList, lsActualList);
        }
    }
}
