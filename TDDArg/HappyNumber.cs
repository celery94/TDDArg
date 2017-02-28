using System;

namespace TDDArg
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            while (n > 6)
            {
                int next = 0;
                while (n > 0)
                {
                    next += (n % 10) * (n % 10);
                    n /= 10;
                }
                n = next;
            }
            return n == 1;
        }
    }
}