using System;
namespace TDDArg
{
	public class LinkedListCycle
	{
		public bool HasCycle(ListNode head)
		{
			var next = head;
			while (head != null && next != null)
			{
				head = head.next;
				next = next.next?.next;

				if (head != null && head == next) return true;
			}

			return false;
		}
	}
}
