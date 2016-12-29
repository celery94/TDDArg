using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class RotateListTest
	{
		[Test]
		public void Given_123_When_rotate_0_Then_123()
		{
			var list = new ListNode(1)
			{
				next = new ListNode(2)
				{
					next = new ListNode(3)
				}
			};

			var result = RotateList.RotateRight(list, 0);

			Assert.AreEqual(1, result.val);
			Assert.AreEqual(2, result.next.val);
			Assert.AreEqual(3, result.next.next.val);
		}

		[Test]
		public void Given_123_When_rotate_1_Then_312()
		{
			var list = new ListNode(1)
			{
				next = new ListNode(2)
				{
					next = new ListNode(3)
				}
			};

			var result = RotateList.RotateRight(list, 1);

			Assert.AreEqual(3, result.val);
			Assert.AreEqual(1, result.next.val);
			Assert.AreEqual(2, result.next.next.val);
		}
	}
}
