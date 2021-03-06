﻿using System;

namespace TDDArg
{
	public class MergeTwoSortedLists
	{
		public static ListNode MergeTwoLists(ListNode head1, ListNode head2)
		{
			var head = new ListNode(0);
			var current = head;

			while (head1 != null && head2 != null)
			{
				if (head1.val < head2.val)
				{
					current.next = head1;
					head1 = head1.next;
				}
				else
				{
					current.next = head2;
					head2 = head2.next;
				}

				current = current.next;
			}

			current.next = head1 ?? head2;

			return head.next;
		}
	}
}