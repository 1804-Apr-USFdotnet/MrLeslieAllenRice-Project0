using System;
using Palindrome;

namespace CodeChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string rc = "racecar";

            Class1 pd = new Class1(rc);
            bool result = pd.PalindromeStringCheck(rc);

            Console.WriteLine(result);
        }
    }
}
