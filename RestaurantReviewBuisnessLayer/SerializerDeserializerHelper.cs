using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestaurantReviewBuisnessLayer
{
    public static class SerializerDeserializerHelper
    {
        public static void SerializeRestaurants(List<Restaurant> r)
        {
            XmlSerializer serializeRestaurants = new XmlSerializer(typeof(List<Restaurant>));
            using (TextWriter writer = new StreamWriter(@"C:\Users\leslierice\source\repos\Restaurants.txt"))
            {
                serializeRestaurants.Serialize(writer, r);
            }
        }

        public static void SerializeRestaurantReviews(List<Review> r)
        {
            XmlSerializer serializeRestaurantReviews = new XmlSerializer(typeof(List<Review>));
            using (TextWriter writer = new StreamWriter(@"C:\Users\leslierice\source\repos\RestaurantReviews.txt"))
            {
                serializeRestaurantReviews.Serialize(writer, r);
            }
        }

        public static void DeserializeRestaurants(List<Restaurant> r)
        {
            XmlSerializer deserializeRestaurants = new XmlSerializer(typeof(List<Restaurant>));
            TextReader reader = new StreamReader(@"C:\Users\leslierice\source\repos\Restaurants.txt");
            object restaurants = deserializeRestaurants.Deserialize(reader);
            List<Restaurant> XmlData = (List<Restaurant>)restaurants;
            reader.Close();
        }

        public static void DeserializeRestaurantReviews(List<Review> r)
        {
            XmlSerializer deserializeRestaurantReviews = new XmlSerializer(typeof(List<Review>));
            TextReader reader = new StreamReader(@"C:\Users\leslierice\source\repos\RestaurantReviews.txt");
            object reviews = deserializeRestaurantReviews.Deserialize(reader);
            List<Restaurant> XmlData = (List<Restaurant>)reviews;
            reader.Close();
        }
    }
}
