using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TDDArg
{
    public class SubstringWithConcatenationOfAllWords
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                int index = s.IndexOf(word);
                while (index != -1)
                {
                    int preIndex = index;
                    int nextIndex = index + word.Length;

                    if (words.Length > 1)
                    {
                        FindString(s, result, words, preIndex, nextIndex, new List<int>() { i });
                    }
                    else
                    {
                        result.Add(index);
                    }

                    index = s.IndexOf(word, index + 1);
                }
            }

            return result;
        }

        private static void FindString(string s, List<int> result, string[] words, int preIndex, int nextIndex, List<int> wordsUsed)
        {
            if (words.Length <= wordsUsed.Count) return;

            for (int index = 0; index < words.Length; index++)
            {
                if (wordsUsed.Contains(index)) continue;

                var word = words[index];
                if (nextIndex + word.Length - 1 < s.Length && s.Substring(nextIndex, word.Length) == word)
                {
                    List<int> used = new List<int>();
                    used.AddRange(wordsUsed);
                    used.Add(index);

                    if (words.Length <= used.Count)
                    {
                        if (!result.Contains(preIndex))
                            result.Add(preIndex);
                    }
                    else
                    {
                        FindString(s, result, words, preIndex, nextIndex + word.Length, used);
                    }
                }

                if (preIndex - word.Length >= 0 && s.Substring(preIndex - word.Length, word.Length) == word)
                {
                    List<int> used = new List<int>();
                    used.AddRange(wordsUsed);
                    used.Add(index);

                    if (words.Length <= used.Count)
                    {
                        if (!result.Contains(preIndex - word.Length))
                            result.Add(preIndex - word.Length);
                    }
                    else
                    {
                        FindString(s, result, words, preIndex - word.Length, nextIndex, used);
                    }
                }
            }
        }
    }
}