using System;

namespace TDDArg
{
    public class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            ListNode head = null;
            if (l1.val < l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }

            var current = head;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    current.next = l2;
                    l2 = null;
                }
                else if (l2 == null)
                {
                    current.next = l1;
                    l1 = null;
                }
                else
                {
                    if (l1.val < l2.val)
                    {
                        current.next = l1;
                        current = current.next;
                        l1 = l1.next;
                    }
                    else
                    {
                        current.next = l2;
                        current = current.next;
                        l2 = l2.next;
                    }
                }
            }

            return head;
        }
    }
}