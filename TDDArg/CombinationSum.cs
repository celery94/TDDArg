using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class CombinationSum
    {
        public static IList<IList<int>> CombinationSumFunc(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            Find(result, new List<int>(), candidates, target);
            return result;
        }

        private static void Find(List<IList<int>> result, List<int> list, int[] candidates, int target)
        {
            foreach (var candidate in candidates)
            {
                List<int> array = new List<int>();
                array.AddRange(list);
                array.Add(candidate);

                if (array.Sum() == target)
                {
                    array = array.OrderBy(q => q).ToList();

                    if (!result.Where(q => q.Count == array.Count).Any(q =>
                         {
                             for (int i = 0; i < q.Count; i++)
                             {
                                 if (q[i] != array[i])
                                 {
                                     return false;
                                 }
                             }

                             return true;
                         }))
                        result.Add(array);
                }
                else if (array.Sum() < target)
                {
                    Find(result, array, candidates, target);
                }
            }
        }
    }
}