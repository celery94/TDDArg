using System;

namespace TDDArg
{
    public class ReverseInt
    {
        public static int Reverse(int x)
        {
            int result = 0;

            int last = x % 10;
            while (x != 0)
            {
                if (x > 0 && (int.MaxValue - last) / 10 < result)
                {
                    return 0;
                }

                if (x < 0 && (int.MinValue / 10 - last / 10) > result)
                {
                    return 0;
                }

                result = result * 10 + last;
                x = x / 10;
                last = x % 10;
            }

            return result;
        }
    }
}