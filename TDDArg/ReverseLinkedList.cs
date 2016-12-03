using System.Data.SqlTypes;

namespace TDDArg
{
    public class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;

            ListNode current = null;

            while (head != null)
            {
                var next = head.next;
                head.next = current;

                current = head;
                head = next;
            }

            return current;
        }
    }
}