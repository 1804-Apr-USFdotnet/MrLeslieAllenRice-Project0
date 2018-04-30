using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewBuisnessLayer;
using RestaurantDataLayer;

namespace RestaurantReviewPresentationLayer
{
    class RRMain
    {
        static void Main(string[] args)
        {
            string iKeepOn = "y";
            RestaurantReviewDisplay.DisplayMenu();
            string iUserInput = Console.ReadLine();
            RRBusinessLogic.ProgramLogic(iUserInput);

            Console.WriteLine("Do you wanna continue? (y for yes / n for no)");
            iKeepOn = Console.ReadLine();

            while (iKeepOn == "y")
            {
                RestaurantReviewDisplay.DisplayMenu();
                iUserInput = Console.ReadLine();
                RRBusinessLogic.ProgramLogic(iUserInput);

                Console.WriteLine("Do you wanna continue? (y for yes / n for no)");
                iKeepOn = Console.ReadLine();
            }

        }
    }
}