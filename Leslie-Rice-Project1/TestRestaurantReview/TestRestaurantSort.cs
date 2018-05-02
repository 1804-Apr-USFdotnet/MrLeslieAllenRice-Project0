using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewBuisnessLayer;
using System.Collections.Generic;
using System.Diagnostics;

namespace RestaurantReviewBusinessLayerTest
{
    [TestClass]
    public class TestRestaurantSort
    {
        [TestMethod]
        public void TestDisplayTopThreeRestaurants()
        {
            // Act
            Restaurant test1 = new Restaurant("Arbys", "2010 Somwhere", 4.4m);
            Restaurant test2 = new Restaurant("Taco Bell", "2010 Somwhere", 2.4m);
            Restaurant test3 = new Restaurant("Burger King", "2010 Somwhere", 3.1m);
            Restaurant test4 = new Restaurant("McDonalds", "2010 Somwhere", 5.0m);
            Restaurant test5 = new Restaurant("Fazolis", "2010 Somwhere", 1.4m);
            Restaurant test6 = new Restaurant("Steak n Shake", "2010 Somwhere", 3.2m);
            Restaurant test7 = new Restaurant("Subway", "2010 Somwhere", 4.8m);
            Restaurant test8 = new Restaurant("In and Out Burger", "2010 Somwhere", 4.1m);
            Restaurant test9 = new Restaurant("KFC", "2010 Somwhere", 0.4m);
            Restaurant test10 = new Restaurant("Sonic", "2010 Somwhere", 1.1m);
            List<Restaurant> lsExpectList = new List<Restaurant> { test4, test7, test1 };


            // Arrange
            List<Restaurant> lsIntermediateList = new List<Restaurant> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };
            List<Restaurant> lsActualList = RestaurantSort.DisplayTopThreeRestaurants(lsIntermediateList);

            // Assert
            CollectionAssert.AreEqual(lsExpectList, lsActualList);

        }

        [TestMethod]
        public void TestDisplayAllRestaurantsAsc()
        {
            // Act
            Restaurant test1 = new Restaurant("Arbys", "2010 Somwhere", 4.4m);
            Restaurant test2 = new Restaurant("Taco Bell", "2010 Somwhere", 2.4m);
            Restaurant test3 = new Restaurant("Burger King", "2010 Somwhere", 3.1m);
            Restaurant test4 = new Restaurant("McDonalds", "2010 Somwhere", 5.0m);
            Restaurant test5 = new Restaurant("Fazolis", "2010 Somwhere", 1.4m);
            Restaurant test6 = new Restaurant("Steak n Shake", "2010 Somwhere", 3.2m);
            Restaurant test7 = new Restaurant("Subway", "2010 Somwhere", 4.8m);
            Restaurant test8 = new Restaurant("In and Out Burger", "2010 Somwhere", 4.1m);
            Restaurant test9 = new Restaurant("KFC", "2010 Somwhere", 0.4m);
            Restaurant test10 = new Restaurant("Sonic", "2010 Somwhere", 1.1m);
            List<Restaurant> lsExpectList = new List<Restaurant> { test1, test3, test5,
            test8, test9, test4, test10, test6, test7, test2};

            // Arrange
            List<Restaurant> lsTestList = new List<Restaurant> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };
            List<Restaurant> lsActualList = RestaurantSort.DisplayAllRestaurantsAsc(lsTestList);

            // Assert
            CollectionAssert.AreEqual(lsExpectList, lsActualList);
        }

        [TestMethod]
        public void TestDisplayAllRestaurantsDesc()
        {
            // Act
            Restaurant test1 = new Restaurant("Arbys", "2010 Somwhere", 4.4m);
            Restaurant test2 = new Restaurant("Taco Bell", "2010 Somwhere", 2.4m);
            Restaurant test3 = new Restaurant("Burger King", "2010 Somwhere", 3.1m);
            Restaurant test4 = new Restaurant("McDonalds", "2010 Somwhere", 5.0m);
            Restaurant test5 = new Restaurant("Fazolis", "2010 Somwhere", 1.4m);
            Restaurant test6 = new Restaurant("Steak n Shake", "2010 Somwhere", 3.2m);
            Restaurant test7 = new Restaurant("Subway", "2010 Somwhere", 4.8m);
            Restaurant test8 = new Restaurant("In and Out Burger", "2010 Somwhere", 4.1m);
            Restaurant test9 = new Restaurant("KFC", "2010 Somwhere", 0.4m);
            Restaurant test10 = new Restaurant("Sonic", "2010 Somwhere", 1.1m);
            List<Restaurant> lsExpectList = new List<Restaurant> { test2, test7, test6,
            test10, test4, test9, test8, test5, test3, test1};

            // Arrange
            List<Restaurant> lsTestList = new List<Restaurant> { test1, test2, test3,
                test4, test5, test6, test7, test8, test9, test10 };
            List<Restaurant> lsActualList = RestaurantSort.DisplayAllRestaurantDesc(lsTestList);

            // Assert
            CollectionAssert.AreEqual(lsExpectList, lsActualList);
        }
    }
}
