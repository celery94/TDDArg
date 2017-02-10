using System;
namespace TDDArg
{
	public class Node
	{
		public int data { get; set; }
		public Node next { get; set; }
	}

	public class MergeTwoSortedLinkedList
	{
		public Node Merge(Node head1, Node head2)
		{
			var head = new Node();
			var current = head;

			while (head1 != null && head2 != null)
			{
				if (head1.data < head2.data)
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
