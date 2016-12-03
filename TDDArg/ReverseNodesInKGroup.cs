namespace TDDArg
{
    public class ReverseNodesInKGroup
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode current = null;

            while (head != null)
            {
                ListNode reversNode = null;
                int count = k;

                var cur = head;
                var nodeCount = 0;
                while (cur != null)
                {
                    nodeCount++;
                    cur = cur.next;
                }

                if (nodeCount < count)
                {
                    reversNode = head;
                    head = null;
                }
                else
                {
                    while (head != null && count > 0)
                    {
                        var next = head.next;
                        head.next = reversNode;
                        reversNode = head;
                        head = next;
                        count--;
                    }
                }

                if (current == null)
                {
                    current = reversNode;
                }
                else
                {
                    var node = current;
                    while (node.next != null)
                    {
                        node = node.next;
                    }

                    node.next = reversNode;
                }
            }
            return current;
        }
    }
}