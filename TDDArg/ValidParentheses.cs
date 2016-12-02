using System.Collections.Generic;

namespace TDDArg
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var ch in s.ToCharArray())
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }

                if (ch == ')')
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                if (ch == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

                if (ch == '}')
                {
                    if (stack.Count > 0 && stack.Peek() == '{')
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