using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class CombinationSum
    {
        public static IList<IList<int>> CombinationSumFunc(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            candidates = candidates.OrderBy(q => q).ToArray();
            Find(result, new List<int>(), candidates, target);
            return result;
        }

        private static void Find(List<IList<int>> result, List<int> list, int[] candidates, int target)
        {
            if (target == 0)
            {
                //TODO check duplicate
                result.Add(new List<int>(list));
            }

            foreach (var candidate in candidates)
            {
                if (candidate <= target)
                {
                    list.Add(candidate);
                    Find(result, list, candidates, target - candidate);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}