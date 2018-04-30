using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RestaurantDataLayer
{
    public static class RestaurantData
    {
        // method to get restaurants
        public static List<Restaurant> ShowAllRestaurants()
        {
            List<Restaurant> lsLocalList = new List<Restaurant>();

            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
                lsLocalList = db.Restaurants.ToList();
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
            }
            catch(SystemException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
            return lsLocalList;
        }

        // method to get reviews
        public static List<Review> ShowRestaurantReviews(string _sRestaurant)
        {
            //Restaurant localRestaurant = new Restaurant();
            List<Review> lsReviews = new List<Review>();
            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
                lsReviews = db.Restaurants.ToList().SingleOrDefault(x => x.rName == _sRestaurant).Reviews.ToList();
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
            }
            catch (SystemException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
            return lsReviews;
        }

        // method to insert record into database
        public static void InsertRestaurantIntoDB(string sRName, string sRAddress, decimal dAvgRating)
        {
            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();

                Restaurant restaurant = new Restaurant()
                {
                    rName = sRName,
                    rAddress = sRAddress,
                    rAvgRating = dAvgRating
                };

                db.Restaurants.Add(restaurant);
                db.SaveChanges();
                Console.Read();
            }
            catch (SqlException se)
            {
                Debug.WriteLine("Exception handled:\n" + se.Message);
                Debug.WriteLine("Stack Trace:\n" + se.StackTrace);
                Console.Read();
            }
            catch (DbException de)
            {
                Debug.WriteLine("Exception handled:\n" + de.Message);
                Debug.WriteLine("Stack Trace:\n" + de.StackTrace);
                Console.Read();
            }
            catch (ExternalException ee)
            {
                Console.WriteLine("Exception handled:\n" + ee.Message);
                Console.WriteLine("Stack Trace:\n" + ee.StackTrace);
            }
            catch (SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception handled:\n" + e.Message);
                Debug.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
        }

        public static void InsertReviewIntoDB(string sRName, string sRvAddress, decimal dRvRating, string sRvSummary)
        {
            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();

                Review review = new Review()
                {
                    rName = sRName,
                    rAddress = sRvAddress,
                    rRating = dRvRating,
                    rSummary = sRvSummary
                };

                db.Reviews.Add(review);
                db.SaveChanges();
               
                
            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch (DbException de)
            {
                Console.WriteLine("Exception handled:\n" + de.Message);
                Console.WriteLine("Stack Trace:\n" + de.StackTrace);
            }
            catch (ExternalException ee)
            {
                Console.WriteLine("Exception handled:\n" + ee.Message);
                Console.WriteLine("Stack Trace:\n" + ee.StackTrace);
            }
            catch (SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
        }

        // method to delete record into database
        public static void DeleteRestaurantFromDB(string sRName, string sRAddress, decimal dRating)
        {
            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();

                Restaurant restaurant = new Restaurant()
                {
                    rName = sRName,
                    rAddress = sRAddress,
                    rAvgRating = dRating
                };

                db.Restaurants.Remove(restaurant);
                db.SaveChanges();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch (DbException de)
            {
                Console.WriteLine("Exception handled:\n" + de.Message);
                Console.WriteLine("Stack Trace:\n" + de.StackTrace);
            }
            catch (ExternalException ee)
            {
                Console.WriteLine("Exception handled:\n" + ee.Message);
                Console.WriteLine("Stack Trace:\n" + ee.StackTrace);
            }
            catch (SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
        }

        public static void DeleteReviewFromDB(string sRName, string sRvAddress, decimal dRating, string sRSummary)
        {
            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();

                Review review = new Review()
                {
                    rName = sRName,
                    rAddress = sRvAddress,
                    rRating = dRating,
                    rSummary = sRSummary
                };

                db.Reviews.Remove(review);
                db.SaveChanges();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch (DbException de)
            {
                Console.WriteLine("Exception handled:\n" + de.Message);
                Console.WriteLine("Stack Trace:\n" + de.StackTrace);
            }
            catch (ExternalException ee)
            {
                Console.WriteLine("Exception handled:\n" + ee.Message);
                Console.WriteLine("Stack Trace:\n" + ee.StackTrace);
            }
            catch (SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
        }
    }
}
