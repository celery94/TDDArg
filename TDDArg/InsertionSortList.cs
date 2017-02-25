using System;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class InsertionSortListClass
	{
		public ListNode InsertionSortList(ListNode head)
		{
			if (head?.next == null) return head;

			var sorted = head;
			var current = head.next;
			sorted.next = null;

			while (current != null)
			{
				var tmp = current.next;
				
				if (current.val <= sorted.val)
				{
					current.next = sorted;
					sorted = current;
				}
				else
				{
					var pre = sorted;
					var next = sorted.next;
					while (next != null && current.val > next.val)
					{
						pre = pre.next;
						next = next.next;
					}

					pre.next = current;
					current.next = next;
				}
				current = tmp;
				
			}

			return sorted;
		}

		[Test]
		public void Given_empty_list_When_sort_Then_return_empty()
		{
			Assert.AreEqual(null, InsertionSortList(null));
		}

		[Test]
		public void Given_list_reverse_When_sort_Then_return()
		{
			var list = new ListNode(1)
			{
				next = new ListNode(1)
			};

			var result = InsertionSortList(list);

			Assert.AreEqual(1, result.val);
			Assert.AreEqual(1, result.next.val);
			Assert.AreEqual(null, result.next.next);
		}

		[Test]
		public void Given_list_When_sort_Then_return()
		{
			var list = new ListNode(1)
			{
				next = new ListNode(5)
				{
					next = new ListNode(2)
				}
			};

			var result = InsertionSortList(list);

			Assert.AreEqual(1, result.val);
			Assert.AreEqual(2, result.next.val);
			Assert.AreEqual(5, result.next.next.val);
			Assert.AreEqual(null, result.next.next.next);
		}
	}
}
