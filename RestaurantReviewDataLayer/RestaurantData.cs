using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Data.Entity;

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
        public static int InsertRestaurantIntoDB(string sRName, string sRAddress, decimal dAvgRating)
        {
            RestaurantDataLayer.Restaurant restaurant = new RestaurantDataLayer.Restaurant()
            {
                rName = sRName,
                rAddress = sRAddress,
                rAvgRating = dAvgRating
            };

            try
            {
                RestaurantReviewP0Entities db;

                using(db = new RestaurantReviewP0Entities())
                {
                    

                    db.Restaurants.Add(restaurant);
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException se)
            {
                Debug.WriteLine("Exception handled:\n" + se.Message);
                Debug.WriteLine("Stack Trace:\n" + se.StackTrace);
                Debug.WriteLine(se.InnerException.Message);
                Debug.WriteLine(se.InnerException);
            }
            catch (SqlException se)
            {
                Debug.WriteLine("Exception handled:\n" + se.Message);
                Debug.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch (DbException de)
            {
                Debug.WriteLine("Exception handled:\n" + de.Message);
                Debug.WriteLine("Stack Trace:\n" + de.StackTrace);
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
            return restaurant.rId;
        }

        public static void InsertReviewIntoDB(string sRName, string sRvAddress, decimal dRvRating,
            string sRvSummary, int iForeignKey)
        {
            try
            {
                RestaurantReviewP0Entities db;

                using (db = new RestaurantReviewP0Entities())
                {
                    Review review = new Review()
                    {
                        rName = sRName,
                        rAddress = sRvAddress,
                        rRating = dRvRating,
                        rSummary = sRvSummary,
                        fk_rId = iForeignKey
                    };

                    db.Reviews.Add(review);
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException se)
            {
                Debug.WriteLine("Exception handled:\n" + se.Message);
                Debug.WriteLine("Stack Trace:\n" + se.StackTrace);
                Debug.WriteLine(se.InnerException.Message);
                Debug.WriteLine(se.InnerException);
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
        public static void DeleteRestaurantFromDB(string sRestaurantInput)
        {
            try
            {
                RestaurantReviewP0Entities db;

                using (db = new RestaurantReviewP0Entities())
                {
                    Restaurant restaurant = db.Restaurants.SingleOrDefault(x => x.rName == sRestaurantInput);
                    db.Restaurants.Attach(restaurant);
                    db.Entry(restaurant).State = EntityState.Deleted;
                    db.Restaurants.Remove(restaurant);
                    db.SaveChanges();
                }
            }
            catch(DbUpdateConcurrencyException duce)
            {
                Console.WriteLine("Exception handled:\n" + duce.Message);
                Console.WriteLine("Stack Trace:\n" + duce.StackTrace);

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

        public static void DeleteReviewFromDB(string sRName, string sRSummary)
        {
            try
            {
                RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();

                Review review = db.Reviews.SingleOrDefault(x => x.rName == sRName);
                db.Reviews.Attach(review);
                db.Entry(review).State = EntityState.Deleted;
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
