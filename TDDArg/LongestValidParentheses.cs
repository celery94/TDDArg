using System.Collections.Generic;

namespace TDDArg
{
    public class LongestValidParentheses
    {
        public static int FindLongestValidParentheses(string s)
        {
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                Queue<char> queue = new Queue<char>();
                int j = i;
                while (j < s.Length)
                {
                    if (queue.Count > 0 && s[j] == ')' && queue.Peek() == '(')
                    {
                        queue.Dequeue();
                        if (queue.Count == 0 && (j - i + 1) > maxLength)
                        {
                            maxLength = j - i + 1;
                        }
                    }
                    else
                    {
                        queue.Enqueue(s[j]);
                    }
                    j++;
                }
            }

            return maxLength;
        }
    }
}