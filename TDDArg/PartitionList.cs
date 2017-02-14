namespace TDDArg
{
    public class PartitionList
    {
        public static ListNode Partition(ListNode head, int x)
        {
            if (head == null) return null;

            ListNode less = null;
            ListNode lessH = null;
            ListNode bigger = null;
            ListNode biggerH = null;

            while (head != null)
            {
                if (head.val < x)
                {
                    if (less == null)
                    {
                        lessH = less = head;
                    }
                    else
                    {
                        less.next = head;
                        less = less.next;
                    }
                }
                else
                {
                    if (bigger == null)
                    {
                        biggerH = bigger = head;
                    }
                    else
                    {
                        bigger.next = head;
                        bigger = bigger.next;
                    }
                }
                head = head.next;
            }

            //mark tie as null
            if (bigger != null)
                bigger.next = null;

            if (lessH == null) return biggerH;

            less.next = biggerH;
            return lessH;
        }
    }
}