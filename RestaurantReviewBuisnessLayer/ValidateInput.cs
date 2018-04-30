using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewBuisnessLayer
{
    public static class ValidateInput
    {
        public static int InputValidation(int _iInput)
        {
            int iReturnInt = 0;

            while (iReturnInt < 1 && iReturnInt > 7)
            {
                Console.Write("Please enter a valid selection (1 - 7): ");
                iReturnInt = Console.Read();
            }

            return _iInput;
        }

        public static int InputValidation(string _sInput)
        {
            int iReturnInt = 0;

            while(iReturnInt < 1 && iReturnInt > 7)
            {
                Console.Write("Please enter a valid selection (1 - 7): ");
                iReturnInt = Console.Read();
            }

            return iReturnInt;
        }
    }
}
