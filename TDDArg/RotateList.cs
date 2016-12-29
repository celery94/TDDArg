using System;
namespace TDDArg
{
	public class RotateList
	{
		public static ListNode RotateRight(ListNode head, int k)
		{
			if (head == null || k == 0) return head;

			var end = head;
			int length = 1;
			while (end.next != null)
			{
				length++;
				end = end.next;
			}
			k = k % length;

			var start = head;
			end = head;

			for (int i = 0; i < k; i++)
			{
				end = end.next;
			}

			while (end.next != null)
			{
				end = end.next;
				start = start.next;
			}

			end.next = head;
			head = start.next;
			start.next = null;

			return head;
		}
	}
}
