using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class LongestValidParentheses
    {
        public static int FindLongestValidParentheses(string s)
        {
            int maxLength = 0;

            var validEnd = s.Length - 1;
            while (validEnd >= 0)
            {
                if (s[validEnd] == '(')
                {
                    validEnd--;
                }
                else
                {
                    break;
                }
            }

            for (int start = 0; start <= validEnd; start++)
            {
                if (s[start] == ')') continue;

                int queue = 0;
                int end = start;
                var nextStart = start;
                while (end <= validEnd)
                {
                    if (s[end] == '(')
                    {
                        queue++;
                    }
                    else
                    {
                        if (queue > 0)
                        {
                            queue--;
                            if (queue == 0)
                            {
                                if (end - start + 1 > maxLength)
                                {
                                    maxLength = end - start + 1;
                                    nextStart = end;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    end++;
                }

                start = nextStart;
            }

            return maxLength;
        }
    }
}