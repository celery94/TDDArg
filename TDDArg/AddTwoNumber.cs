using System;

namespace TDDArg
{
    public class AddTwoNumber
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode current = null;
            ListNode head = null;
            bool isMaxThanTen = false;
            while (l1 != null || l2 != null)
            {
                var result = (l1?.val ?? 0) + (l2?.val ?? 0) + (isMaxThanTen ? 1 : 0);

                if (current == null)
                {
                    head = current = new ListNode(result % 10);
                }
                else
                {
                    current.next = new ListNode(result % 10);
                    current = current.next;
                }

                isMaxThanTen = result >= 10;

                l1 = l1?.next;

                l2 = l2?.next;
            }

            if (isMaxThanTen)
            {
                current.next = new ListNode(1);
            }

            return head;
        }
    }
}