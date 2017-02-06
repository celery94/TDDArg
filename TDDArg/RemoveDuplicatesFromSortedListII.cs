namespace TDDArg
{
    public class RemoveDuplicatesFromSortedListII
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head?.next == null) return head;

            var next = head.next;

            var preSame = false;
            while (next != null)
            {
                if (head.val == next.val)
                {
                    preSame = true;
                }
                else
                {
                    if (preSame == false)
                        break;

                    preSame = false;
                }

                head = next;
                next = next.next;
            }

            //if (next != null)
            //{
            //    var pre = head;
            //    var current = next;
            //    next = next.next;
            //    while (next != null && current != null)
            //    {
            //        if (current.val == next.val)
            //        {
            //            current = next;
            //            next = next.next;
            //        }
            //        else
            //        {
            //            pre.next = next;
            //        }
            //    }
            //}

            return head;
        }
    }
}