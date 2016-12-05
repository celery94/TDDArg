using System;

namespace TDDArg
{
    public class DivideTwoIntegers
    {
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0 || (dividend == int.MinValue && divisor == -1)) return int.MaxValue;

            if (divisor == 1)
            {
                return dividend;
            }
            if (divisor == -1)
            {
                return 0 - dividend;
            }

            bool isNagetive = dividend < 0;
            bool isNagetiveDiv = divisor < 0;

            if (!isNagetive)
            {
                dividend = 0 - dividend;
            }
            if (!isNagetiveDiv)
            {
                divisor = 0 - divisor;
            }

            if (divisor < dividend) return 0;

            int result = 0;

            while (dividend <= divisor)
            {
                int index = 1;
                var divisorSum = divisor;

                dividend = dividend - divisorSum;
                while (dividend <= 0)
                {
                    result += index;

                    if (divisorSum < int.MinValue - divisorSum)
                    {
                        break;
                    }

                    divisorSum += divisorSum; //May min that int.MinValue
                    index += index;

                    if (dividend - divisorSum <= 0)
                    {
                        dividend = dividend - divisorSum;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (isNagetive != isNagetiveDiv)
            {
                return 0 - result;
            }
            else
            {
                return result;
            }
        }
    }
}