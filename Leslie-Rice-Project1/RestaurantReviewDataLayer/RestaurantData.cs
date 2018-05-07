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
            RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
            List<Restaurant> lsLocalList = new List<Restaurant>();

            try
            {
                lsLocalList = db.Restaurants.ToList();
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
            }
            catch(SystemException se)
            {
                Debug.WriteLine("Exception handled:\n" + se.Message);
                Debug.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
            return lsLocalList;
        }

        public static List<Review> ShowAllReviews()
        {
            RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
            List<Review> lsLocalList = new List<Review>();

            try
            {
                lsLocalList = db.Reviews.ToList();
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
            }
            catch (SystemException se)
            {
                Debug.WriteLine("Exception handled:\n" + se.Message);
                Debug.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
            return lsLocalList;
        }

        // method to get reviews
        public static List<Review> ShowReviewsForRestaurant(string sRestName)
        {
            RestaurantReviewP0Entities db = new RestaurantReviewP0Entities();
            List<Review> lsAllReviews = ShowAllReviews();
            List<Review> localReviewList = new List<Review>();

            try
            {
                localReviewList = (from r in lsAllReviews
                            where r.rName == sRestName
                            select r).ToList();
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
            return localReviewList;
        }

        // method to insert record into database
        public static void InsertRestaurantIntoDB(string sRestName, string sAddress)
        {
            RestaurantReviewP0Entities db;
            Restaurant restaurant = new Restaurant()
            {
                rName = sRestName,
                rAddress = sAddress,
                rAvgRating = 0.0m
            };

            try
            {
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
        }

        public static int InsertReviewIntoDB(Review rv)
        {
            RestaurantReviewP0Entities db;
            Review localReview = new Review()
            {
                rName = rv.rName,
                rAddress = rv.rAddress,
                rRating = rv.rRating,
                rSummary = rv.rSummary,
                fk_rId = rv.fk_rId
            };
 
            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    db.Reviews.Add(localReview);
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
            return localReview.rvId;
        }

        // method to update record into database
        public static void UpdateRestaurantInDB(string sRestName, string sAddress)
        {
            Restaurant localRestaurant;
            RestaurantReviewP0Entities db;

            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    localRestaurant = db.Restaurants.Single(x => x.rName == sRestName);

                    localRestaurant.rName = sRestName;
                    localRestaurant.rAddress = sAddress;

                    db.Restaurants.Attach(localRestaurant);
                    db.Entry(localRestaurant).State = EntityState.Modified;
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
        }

       
        public static void UpdateReviewInDB(Review rv)
        {
            RestaurantReviewP0Entities db;
            Review localReview;
            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    localReview = db.Reviews.Single(x => x.rvId == rv.rvId);

                    localReview.rRating = rv.rRating;
                    localReview.rSummary = rv.rSummary;

                    db.Reviews.Attach(localReview);
                    db.Entry(localReview).State = EntityState.Modified;
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
        public static void DeleteRestaurantFromDB(string sRestName)
        {
            RestaurantReviewP0Entities db;
            Restaurant localRestaurant;
            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    localRestaurant = db.Restaurants.SingleOrDefault(x => x.rName == sRestName);
                    db.Restaurants.Attach(localRestaurant);
                    db.Entry(localRestaurant).State = EntityState.Deleted;
                    db.Restaurants.Remove(localRestaurant);
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

        public static void DeleteReviewFromDB(Review rv)
        {
            RestaurantReviewP0Entities db;
            Review localReview;
            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    localReview = db.Reviews.SingleOrDefault(x => x.rvId == rv.rvId);
                    db.Reviews.Attach(localReview);
                    db.Entry(localReview).State = EntityState.Deleted;
                    db.Reviews.Remove(localReview);
                    db.SaveChanges();
                }
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
