using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class PrintLinkedListFromEndTest
	{
		[Test]
		public void Given_list_When_print_Then_return()
		{
			ListNode root = new ListNode(1)
			{
				next = new ListNode(2)
				{
					next = new ListNode(3)
				}
			};

			var result = PrintLinkedListFromEnd.Print(root);

			Assert.AreEqual(3, result[0]);
			Assert.AreEqual(2, result[1]);
			Assert.AreEqual(1, result[2]);
		}
	}
}
