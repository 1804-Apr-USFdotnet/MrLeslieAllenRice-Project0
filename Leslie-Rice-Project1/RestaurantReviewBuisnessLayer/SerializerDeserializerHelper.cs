using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace RestaurantReviewBuisnessLayer
{
    public static class SerializerDeserializerHelper
    {
        public static void SerializeRestaurants(List<Restaurant> r)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                XmlSerializer serializeRestaurants = new XmlSerializer(typeof(List<Restaurant>));
                using (TextWriter writer = new StreamWriter(@"C:\Revature\MrLeslieAllenRice-Project0\Restaurants.txt"))
                {
                    serializeRestaurants.Serialize(writer, r);
                }
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
                logger.Info(se);
            }
            catch(SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
                logger.Info(syse);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
                logger.Info(e);
            }
            
        }

        public static void SerializeRestaurantReviews(List<Review> r)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                XmlSerializer serializeRestaurantReviews = new XmlSerializer(typeof(List<Review>));
                using (TextWriter writer = new StreamWriter(@"C:\Revature\MrLeslieAllenRice-Project0\RestaurantReviews.txt"))
                {
                    serializeRestaurantReviews.Serialize(writer, r);
                }
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
                logger.Info(se);
            }
            catch (SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
                logger.Info(syse);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
                logger.Info(e);
            }
        }

        public static void DeserializeRestaurants(List<Restaurant> r)
        {
            TextReader reader = new StreamReader(@"C:\Revature\MrLeslieAllenRice-Project0\RestaurantReviews.txt");
            var logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                XmlSerializer deserializeRestaurants = new XmlSerializer(typeof(List<Restaurant>));
                object restaurants = deserializeRestaurants.Deserialize(reader);
                List<Restaurant> XmlData = (List<Restaurant>)restaurants;
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
                logger.Info(ioe);
            }
            catch(XmlException xe)
            {
                Console.WriteLine("Exception handled:\n" + xe.Message);
                Console.WriteLine("Stack Trace:\n" + xe.StackTrace);
                logger.Info(xe);
            }
            catch(SystemException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
                logger.Info(se);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
                logger.Info(e);
            }
            finally
            {
                reader.Close();
            }
        }

        public static void DeserializeRestaurantReviews(List<Review> r)
        {
            TextReader reader = new StreamReader(@"C:\Revature\MrLeslieAllenRice-Project0\RestaurantReviews.txt");
            var logger = NLog.LogManager.GetCurrentClassLogger();

            try
            {
                XmlSerializer deserializeRestaurantReviews = new XmlSerializer(typeof(List<Review>));
                object reviews = deserializeRestaurantReviews.Deserialize(reader);
                List<Restaurant> XmlData = (List<Restaurant>)reviews;
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("Exception handled:\n" + ioe.Message);
                Console.WriteLine("Stack Trace:\n" + ioe.StackTrace);
                logger.Info(ioe);
            }
            catch (XmlException xe)
            {
                Console.WriteLine("Exception handled:\n" + xe.Message);
                Console.WriteLine("Stack Trace:\n" + xe.StackTrace);
                logger.Info(xe);
            }
            catch (SystemException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
                logger.Info(se);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
                logger.Info(e);
            }
            finally
            {
                reader.Close();
            }
        }
    }
}