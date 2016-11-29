using System;
using System.Linq.Expressions;
using System.Text;

namespace TDDArg
{
    public class LongestCommonPrefix
    {
        public static string LongestCommonPrefixFunc(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;

            StringBuilder result = new StringBuilder();

            var index = 0;
            while (index >= 0)
            {
                char ch = Char.MinValue;
                for (int i = 0; i < strs.Length; i++)
                {
                    if (index > strs[i].Length - 1)
                    {
                        index = -2;
                        break;
                    }

                    if (i == 0)
                    {
                        ch = strs[i][index];
                    }
                    else
                    {
                        if (strs[i][index] != ch)
                        {
                            index = -2;
                            break;
                        }
                    }

                    if (i == strs.Length - 1)
                    {
                        result.Append(ch);
                    }
                }
                index++;
            }

            return result.ToString();
        }
    }
}