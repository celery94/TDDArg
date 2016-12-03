using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (!lists.Any() || lists.All(q => q == null)) return null;

            int minVal = Int32.MaxValue;
            int index = -1;
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    if (lists[i].val < minVal)
                    {
                        minVal = lists[i].val;
                        index = i;
                    }
                }
            }

            var head = lists[index];
            lists[index] = lists[index].next;

            var current = head;
            while (lists.Any(q => q != null))
            {
                minVal = Int32.MaxValue;
                index = -1;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] != null)
                    {
                        if (lists[i].val < minVal)
                        {
                            minVal = lists[i].val;
                            index = i;
                        }
                    }
                }

                current.next = lists[index];
                current = current.next;
                lists[index] = lists[index].next;
            }

            return head;
        }
    }
}