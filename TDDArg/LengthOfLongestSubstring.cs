using System;

namespace TDDArg
{
    public class LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstringFunc(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            int start = 0;
            int end = 0;

            int count = end - start + 1;
            while (end < s.Length)
            {
                if (start == end)
                {
                    if (end - start + 1 > count)
                    {
                        count = end - start + 1;
                    }

                    end++;
                }
                else
                {
                    var index = s.Substring(start, end - start).IndexOf(s[end]);

                    if (index != -1)
                    {
                        start = start + index + 1;
                        end++;
                    }
                    else
                    {
                        if (end - start + 1 > count)
                        {
                            count = end - start + 1;
                        }

                        end++;
                    }
                }
            }

            return count;
        }
    }
}