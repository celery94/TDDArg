using System;
using System.Collections.Generic;
using System.Text;

namespace TDDArg
{
    public class GenerateParentheses
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();

            AppendString(result, "", 0, 0, n);

            return result;
        }

        private static void AppendString(List<string> result, string sb, int open, int close, int max)
        {
            if (sb.Length == max * 2)
            {
                result.Add(sb.ToString());
                return;
            }

            if (open < max)
                AppendString(result, sb + "(", open + 1, close, max);

            if (close < open)
                AppendString(result, sb + ")", open, close + 1, max);
        }
    }
}