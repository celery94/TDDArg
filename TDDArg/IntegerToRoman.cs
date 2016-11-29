using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TDDArg
{
    public class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            string result = "";
            var length = num.ToString().Length;
            for (int i = 0; i < length; i++)
            {
                string one;
                string five;
                string nextOne;
                one = five = nextOne = string.Empty;

                var remainder = num % 10;
                num = num / 10;

                if (i == 0)
                {
                    one = "I";
                    five = "V";
                    nextOne = "X";
                }
                else if (i == 1)
                {
                    one = "X";
                    five = "L";
                    nextOne = "C";
                }
                else if (i == 2)
                {
                    one = "C";
                    five = "D";
                    nextOne = "M";
                }
                else if (i == 3)
                {
                    one = "M";
                    five = "";
                    nextOne = "";
                }

                result = GetResult(remainder, one, five, nextOne) + result;
            }

            return result;
        }

        private static string GetResult(int num, string one, string five, string nextOne)
        {
            var result = "";

            if (num < 4)
            {
                for (int i = 0; i < num; i++)
                {
                    result += one;
                }
            }
            else if (num == 4)
            {
                result = one + five;
            }
            else if (num == 5)
            {
                result = five;
            }
            else if (num < 9)
            {
                result = five + GetResult(num - 5, one, five, nextOne);
            }
            else if (num == 9)
            {
                result = one + nextOne;
            }
            return result;
        }
    }
}