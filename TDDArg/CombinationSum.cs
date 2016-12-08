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
            Find(result, new List<int>(), candidates, target, 0);
            return result;
        }

        private static void Find(List<IList<int>> result, List<int> list, int[] candidates, int target, int start)
        {
            if (target == 0)
            {
                result.Add(new List<int>(list));
            }

            for (int index = start; index < candidates.Length; index++)
            {
                var candidate = candidates[index];
                if (candidate <= target)
                {
                    list.Add(candidate);
                    Find(result, list, candidates, target - candidate, index);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}