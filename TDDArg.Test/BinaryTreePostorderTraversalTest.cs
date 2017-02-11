using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class BinaryTreePostorderTraversalTest
	{
		[Test]
		public void Given_tree_When_traversal_return()
		{
			TreeNode node = new TreeNode(1)
			{
				left = new TreeNode(2),
				right = new TreeNode(3)
			};

			var result = BinaryTreePostorderTraversal.PostorderTraversal(node);

			Assert.AreEqual(2, result[0]);
			Assert.AreEqual(3, result[1]);
			Assert.AreEqual(1, result[2]);
		}
	}
}
