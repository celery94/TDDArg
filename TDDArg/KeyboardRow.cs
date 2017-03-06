using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            string[] keyboardRows = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };

            Dictionary<char, int> mapping = new Dictionary<char, int>();

            for (int i = 0; i < keyboardRows.Length; i++)
            {
                foreach (var ch in keyboardRows[i])
                {
                    mapping.Add(ch, i);
                }
            }

            return words.Where(word => word.ToLower().ToCharArray().Select(q => mapping[q]).Distinct().Count() == 1).ToArray();
        }
    }
}