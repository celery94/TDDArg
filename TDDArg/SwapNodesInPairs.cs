using System;

namespace TDDArg
{
    public class SwapNodesInPairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head?.next == null) return head;

            var next = head.next;
            head.next = next.next;
            next.next = head;

            head.next = SwapPairs(head.next);

            return next;
        }
    }
}