using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class ConvertSortedArrayToBinarySearchTreeTest
	{
		[Test]
		public void Given_empty_array_When_convert_Then_return_null()
		{
			Assert.AreEqual(null, ConvertSortedArrayToBinarySearchTree.SortedArrayToBST(new int[] { }));
		}

		[Test]
		public void Given_array_1_item_When_convert_Then_return_root()
		{
			var result = ConvertSortedArrayToBinarySearchTree.SortedArrayToBST(new int[] { 1 });
			Assert.AreEqual(1, result.val);
		}

		[Test]
		public void Given_array_2_item_When_convert_Then_return_root()
		{
			var result = ConvertSortedArrayToBinarySearchTree.SortedArrayToBST(new int[] { 1, 2 });
			Assert.AreEqual(1, result.val);
		}
	}
}
