using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (!dic.ContainsKey(c))
                    dic.Add(c, -1);
            }

            int cursor = 0;
            var result = string.Empty;
            while (cursor < s.Length)
            {
                if (dic.ContainsKey(s[cursor]))
                {
                    dic[s[cursor]] = cursor;
                }

                if (dic.All(q => q.Value >= 0))
                {
                    var start = dic.Min(q => q.Value);
                    var substr = s.Substring(start, cursor - start + 1);

                    if (result == string.Empty || substr.Length < result.Length)
                        result = substr;
                }

                cursor++;
            }

            return result;
        }
    }
}