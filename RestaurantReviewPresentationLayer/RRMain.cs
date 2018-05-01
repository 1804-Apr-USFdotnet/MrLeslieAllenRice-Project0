using System;
using RestaurantReviewBuisnessLayer;

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

            Console.WriteLine();
            Console.WriteLine("Do you wanna continue? (y for yes / n for no)");
            iKeepOn = Console.ReadLine();

            while (iKeepOn == "y")
            {
                RestaurantReviewDisplay.DisplayMenu();
                iUserInput = Console.ReadLine();
                RRBusinessLogic.ProgramLogic(iUserInput);

                Console.WriteLine();
                Console.WriteLine("Do you wanna continue? (y for yes / n for no)");
                iKeepOn = Console.ReadLine();
            }
        }
    }
}