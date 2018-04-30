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
            try
            {
                XmlSerializer serializeRestaurants = new XmlSerializer(typeof(List<Restaurant>));
                using (TextWriter writer = new StreamWriter(@"C:\Users\leslierice\source\repos\Restaurants.txt"))
                {
                    serializeRestaurants.Serialize(writer, r);
                }
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
            }
            catch(SystemException syse)
            {
                Console.WriteLine("Exception handled:\n" + syse.Message);
                Console.WriteLine("Stack Trace:\n" + syse.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled:\n" + e.Message);
                Console.WriteLine("Stack Trace:\n" + e.StackTrace);
            }
            
        }

        public static void SerializeRestaurantReviews(List<Review> r)
        {
            try
            {
                XmlSerializer serializeRestaurantReviews = new XmlSerializer(typeof(List<Review>));
                using (TextWriter writer = new StreamWriter(@"C:\Users\leslierice\source\repos\RestaurantReviews.txt"))
                {
                    serializeRestaurantReviews.Serialize(writer, r);
                }
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Exception handled:\n" + se.Message);
                Console.WriteLine("Stack Trace:\n" + se.StackTrace);
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

        public static void DeserializeRestaurants(List<Restaurant> r)
        {
            TextReader reader = new StreamReader(@"C:\Users\leslierice\source\repos\Restaurants.txt");
            
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
            }
            catch(XmlException xe)
            {
                Console.WriteLine("Exception handled:\n" + xe.Message);
                Console.WriteLine("Stack Trace:\n" + xe.StackTrace);
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
            finally
            {
                reader.Close();
            }
        }

        public static void DeserializeRestaurantReviews(List<Review> r)
        {
            TextReader reader = new StreamReader(@"C:\Users\leslierice\source\repos\RestaurantReviews.txt");

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
            }
            catch (XmlException xe)
            {
                Console.WriteLine("Exception handled:\n" + xe.Message);
                Console.WriteLine("Stack Trace:\n" + xe.StackTrace);
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
            finally
            {
                reader.Close();
            }
        }
    }
}