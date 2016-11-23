using System;

namespace TDDArg
{
    public class AddTwoNumber
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(l1.Val + l2.Val);

            var current = head;
            while (l1.Next != null && l2.Next != null)
            {
                l1 = l1.Next;
                l2 = l2.Next;
                current.Next = new ListNode(l1.Val + l2.Val);
                current = current.Next;
            }

            return head;
        }
    }
}