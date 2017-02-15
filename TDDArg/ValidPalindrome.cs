using System;

namespace TDDArg
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (!Char.IsLetterOrDigit((s[start]))) { start++; continue; }
                if (!Char.IsLetterOrDigit((s[end]))) { end--; continue; }

                if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
                {
                    return false;
                }
                else
                {
                    start++;
                    end--;
                }
            }

            return true;
        }
    }
}