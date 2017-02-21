using System;
namespace TDDArg
{
	public class RemoveLinkedListElements
	{
		public ListNode RemoveElements(ListNode head, int val)
		{
			while (head != null && head.val == val)
			{
				head = head.next;
			}

			if (head == null || head.next == null) return head;

			var pre = head;
			var current = head.next;

			while (current != null)
			{
				var next = current.next;
				if (current.val == val)
				{
					pre.next = next;
					current = next;
				}
				else
				{
					pre = pre.next;
					current = current.next;
				}
			}

			return head;
		}
	}
}
