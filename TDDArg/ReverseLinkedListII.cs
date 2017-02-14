using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDArg
{
    public class ReverseLinkedListII
    {
        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode pre = null;

            int index = 1;
            if (m > 1)
            {
                pre = head;
                index++;

                while (index < m)
                {
                    pre = pre.next;
                    index++;
                }
            }

            var current = pre == null ? head : pre.next;
            var next = current.next;

            var mnode = current;
            var mpre = pre;

            while (m <= n)
            {
                current.next = pre;
                pre = current;
                current = next;
                next = next?.next;
                m++;
            }

            mnode.next = current;

            if (mpre != null)
            {
                mpre.next = pre;
                return head;
            }
            else
            {
                return pre;
            }
        }
    }
}
