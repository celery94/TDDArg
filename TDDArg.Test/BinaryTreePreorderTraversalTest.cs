using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class BinaryTreePreorderTraversalTest
	{
		[Test]
		public void Given_tree_When_traversal_return()
		{
			TreeNode node = new TreeNode(1)
			{
				left = new TreeNode(2),
				right = new TreeNode(3)
			};

			var result = BinaryTreePreorderTraversal.PreorderTraversal(node);

			Assert.AreEqual(1, result[0]);
			Assert.AreEqual(2, result[1]);
			Assert.AreEqual(3, result[2]);
		}
	}
}
