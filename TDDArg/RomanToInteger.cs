using System.Collections.Generic;

namespace TDDArg
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            int result = 0;

            int index = s.Length - 1;
            var preChar = ' ';
            while (index >= 0)
            {
                if (preChar != ' ' && dictionary[s[index]] < dictionary[preChar])
                {
                    result -= dictionary[s[index]];
                }
                else
                {
                    result += dictionary[s[index]];
                }

                preChar = s[index];

                index--;
            }

            return result;
        }
    }
}