using System;
namespace TDDArg
{
	public class RotateList
	{
		public static ListNode RotateRight(ListNode head, int k)
		{
			var end = head;

			while (end.next != null)
			{
				end = end.next;
			}

			end.next = head;

			for (int i = 0; i <= k; i++)
			{
				head = head.next;
			}

			var newHead = head.next;
			head.next = null;

			return newHead;
		}
	}
}
