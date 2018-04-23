using System;

namespace Palindrome
{
    public class Class1
    {
        string sStringToCheck;
        bool result;

        public string StringToCheck { get; set; }

        public Class1()
        {
            sStringToCheck = null;
        }

        public Class1(string _sStringToCheck)
        {
            sStringToCheck = _sStringToCheck;
        }

        public bool PalindromeStringCheck(string _sStringToCheck)
        {
            string saComparisonString;
            saComparisonString = _sStringToCheck;

            Console.WriteLine("Comparison String: " + saComparisonString);

            for (int i = _sStringToCheck.Length-1; i >= 0; i--)
            {
                if(saComparisonString[i] == sStringToCheck[i])
                {
                    Console.WriteLine(saComparisonString[i]);
                    result = true;
                }
                else if(saComparisonString[i] != sStringToCheck[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
