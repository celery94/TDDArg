using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class MaximumDepthOfBinaryTreeTest
	{
		[Test]
		public void Given_empty_tree_When_find_Then_return_0()
		{
			Assert.AreEqual(0, MaximumDepthOfBinaryTree.MaxDepth(null));
		}

		[Test]
		public void Given_tree_only_root_When_find_Then_return_1()
		{
			Assert.AreEqual(1, MaximumDepthOfBinaryTree.MaxDepth(new TreeNode(0)));
		}

		[Test]
		public void Given_tree_2_level_When_find_Then_return_2()
		{
			Assert.AreEqual(2, MaximumDepthOfBinaryTree.MaxDepth(new TreeNode(0)
			{
				left = new TreeNode(1),
				right = new TreeNode(2)
			}));
		}

		[Test]
		public void Given_tree_m_level_When_find_Then_return_m()
		{
			Assert.AreEqual(3, MaximumDepthOfBinaryTree.MaxDepth(new TreeNode(0)
			{
				left = new TreeNode(1)
				{

				},
				right = new TreeNode(2)
				{
					left = new TreeNode(3)
				}
			}));
		}
	}
}
