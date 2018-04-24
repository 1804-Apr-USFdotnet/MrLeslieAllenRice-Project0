using System;

namespace Palindrome
{
    public class Class1
    {
        string sStringToCheck;
        string sComparisonString;
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
            int iUpperBound = sStringToCheck.Length-1;
            int iLowerBound;

            for (iLowerBound = 0; iLowerBound <= iUpperBound; iLowerBound++)
            {
                if (_sStringToCheck[iLowerBound].Equals(_sStringToCheck[iUpperBound]))
                {
                    if (iUpperBound == iLowerBound)
                    {
                        iUpperBound--;
                        result = true;
                    }
                    iUpperBound--;
                    continue;
                }
                else
                {
                    iUpperBound--;
                    result = false;
                    break;
                }
            }
            
            return result;
        }
    }
}
