using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewBuisnessLayer;

namespace RestaurantReviewPresentationLayer
{
    class RRMain
    {
        static void Main(string[] args)
        {
            int iKeepOn = 0;
            RestaurantReviewDisplay.DisplayMenu();
            string iUserInput = Console.ReadLine();
            //Console.WriteLine(iUserInput);
            RRBusinessLogic.ProgramLogic(iUserInput);

            if(iKeepOn == 0)
            {
                Console.WriteLine("Do you wanna continue?");
                Console.Read();
            }
            
            
        }
    }
}
