using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class LetterCombinationsOfAPhoneNumber
    {
        public static IList<string> LetterCombinations(string digits)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"2","abc" },
                {"3","def" },
                {"4","ghi" },
                {"5","jkl" },
                {"6","mno" },
                {"7","pqrs" },
                {"8","tuv" },
                {"9","wxyz" },
            };

            List<string> resultList = new List<string>();

            foreach (var digit in digits)
            {
                if (resultList.Count == 0)
                {
                    resultList.AddRange(dictionary[digit.ToString()].ToCharArray().Select(q => q.ToString()));
                }
                else
                {
                    List<string> list = new List<string>();
                    foreach (var ch in dictionary[digit.ToString()])
                    {
                        foreach (var item in resultList)
                        {
                            list.Add(item + ch);
                        }
                    }

                    resultList = list;
                }
            }

            return resultList;
        }
    }
}