namespace TDDArg
{
    public class RemoveDuplicatesFromSortedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return head;

            var pre = head;
            var next = head.next;

            while (next != null)
            {
                if (next.val == pre.val)
                {
                    next = next.next;
                    pre.next = next;
                }
                else
                {
                    pre = next;
                    next = next.next;
                }
            }

            return head;
        }
    }
}