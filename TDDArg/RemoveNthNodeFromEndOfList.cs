namespace TDDArg
{
    public class RemoveNthNodeFromEndOfList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var end = head;
            while (n > 0)
            {
                if (end == null) return null;

                end = end.next;
                n--;
            }

            if (end == null)
            {
                return head.next;
            }

            var removeNode = head;
            while (end.next != null)
            {
                removeNode = removeNode.next;
                end = end.next;
            }

            removeNode.next = removeNode.next.next;

            return head;
        }
    }
}