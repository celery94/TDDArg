using System.Collections.Generic;

namespace TDDArg
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> dictionary = new Dictionary<char, char>()
            {
                {')','(' },
                {']','['},
                {'}','{' },
            };

            Stack<char> stack = new Stack<char>();

            foreach (var ch in s.ToCharArray())
            {
                if (dictionary.ContainsValue(ch))
                {
                    stack.Push(ch);
                }

                if (dictionary.ContainsKey(ch))
                {
                    if (stack.Count > 0 && stack.Peek() == dictionary[ch])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}