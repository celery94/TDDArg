using System;

namespace TDDArg
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            if (x / 10 == 0)
            {
                return true;
            }
            else if (x / 10 == x % 10)
            {
                return true;
            }
            else
            {
                return x / (int) Math.Pow(10, x.ToString().Length - 1) == x % 10 &&
                       IsPalindrome(x % (int) Math.Pow(10, x.ToString().Length - 1) / 10);
            }
        }
    }
}