using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Data.Entity;
using RestaurantDataLayer;

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

        public static void InsertReviewIntoDB(string sRestName, string sAddress,
            decimal dRating, string sRevSummary, int iFk_RId)
        {
            RestaurantReviewP0Entities db;
            Review localReview = new Review()
            {
                rName = sRestName,
                rAddress = sAddress,
                rRating = dRating,
                rSummary = sRevSummary,
                fk_rId = iFk_RId
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
        
        public static void UpdateReviewInDB(string sRestName, string sAddress,
            decimal dRating, string sSummary )
        {
            Review localReview;
            try
            {
                using (var db = new RestaurantReviewP0Entities())
                {
                    localReview = db.Reviews.Single(x => x.rName == sRestName);

                    localReview.rRating = dRating;
                    localReview.rSummary = sSummary;

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
            List<Restaurant> lsRestaurants = ShowAllRestaurants();
            RestaurantReviewP0Entities db;
            List<Review> lsAllReviews = ShowAllReviews();

            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    var query = (from rv in lsRestaurants
                                 where rv.rName == sRestName
                                 select rv);
                    db.Reviews.Attach((Review)query);
                    db.Entry(query.Cast<Review>()).State = EntityState.Deleted;
                    db.Reviews.Remove((Review)query);
                    db.SaveChanges();

                    //lsAllReviews = ShowReviewsForRestaurant(sRestName);
                    //foreach(var item in lsAllReviews)
                    //{
                    //    db.Reviews.Attach(item);
                    //    db.Entry(item).State = EntityState.Deleted;
                    //    db.Reviews.Remove(item);
                    //    db.SaveChanges();
                    //}

                    //List<Review> lsRev = db.Reviews.SingleOrDefault(x => x.rName == sRestName);
                    Restaurant r = db.Restaurants.SingleOrDefault(x => x.rName == sRestName);
                    db.Restaurants.Attach(r);
                    db.Entry(r).State = EntityState.Deleted;
                    db.Restaurants.Remove(r);
                    db.SaveChanges();
                }
            }
            catch(DbUpdateConcurrencyException duce)
            {
                Console.WriteLine("Exception handled:\n" + duce.Message);
                Console.WriteLine("Stack Trace:\n" + duce.StackTrace);
                Debug.WriteLine(duce.InnerException.Message);
                Debug.WriteLine(duce.InnerException);

            }
            catch (SqlException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
                Debug.WriteLine(se.InnerException.Message);
                Debug.WriteLine(se.InnerException);
            }
            catch (DbException de)
            {
                Console.WriteLine("Exception handled:\n" + de.Message);
                Console.WriteLine("Stack Trace:\n" + de.StackTrace);
                Debug.WriteLine(de.InnerException.Message);
                Debug.WriteLine(de.InnerException);
            }
            catch (ExternalException ee)
            {
                Console.WriteLine("Exception handled:\n" + ee.Message);
                Console.WriteLine("Stack Trace:\n" + ee.StackTrace);
                Debug.WriteLine(ee.InnerException.Message);
                Debug.WriteLine(ee.InnerException);
            }
            catch (SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
                Debug.WriteLine(syse.InnerException.Message);
                Debug.WriteLine(syse.InnerException);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
                Debug.WriteLine(e.InnerException.Message);
                Debug.WriteLine(e.InnerException);
            }
        }

        public static void DeleteReviewFromDB(string sRestName, decimal dRating, string sSummary)
        {
            RestaurantReviewP0Entities db;
            var lsReviews = ShowAllReviews();
            try
            {
                using (db = new RestaurantReviewP0Entities())
                {
                    var query = (from r in lsReviews
                                 where r.rName == sRestName && r.rRating == dRating && r.rSummary == sSummary
                                 select r);

                    db.Reviews.Attach((Review)query);
                    db.Entry(query).State = EntityState.Deleted;
                    db.Reviews.Remove((Review)query);
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

        public static int GetRestaurantId(string rName)
        {
            using(var db = new RestaurantReviewP0Entities())
            {
                return db.Restaurants.SingleOrDefault(r => r.rName == rName).rId;
            }
        }
        
    }
}
