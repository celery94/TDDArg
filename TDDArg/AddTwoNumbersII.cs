using System.Collections.Generic;

namespace TDDArg
{
    public class AddTwoNumbersII
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            while (l1 != null)
            {
                stack1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                stack2.Push(l2.val);
                l2 = l2.next;
            }

            bool isBiggerThan10 = false;
            ListNode current = null;
            while (stack1.Count > 0 || stack2.Count > 0)
            {
                var value = (stack1.Count > 0 ? stack1.Pop() : 0) + (stack2.Count > 0 ? stack2.Pop() : 0);
                if (isBiggerThan10) value++;

                isBiggerThan10 = value > 9;

                ListNode node = new ListNode(value % 10);
                node.next = current;
                current = node;
            }

            if (isBiggerThan10)
            {
                ListNode head = new ListNode(1)
                {
                    next = current
                };
                return head;
            }

            return current;
        }
    }
}