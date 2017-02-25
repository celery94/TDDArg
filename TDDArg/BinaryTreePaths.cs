using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class BinaryTreePathsClass
	{
		List<string> BinaryTreePaths(TreeNode root)
		{
			if (root == null) return new List<string>();

			List<string> list = new List<string>();

			SearchPath(root, "", list);

			return list;
		}

		private void SearchPath(TreeNode node, string path, List<string> list)
		{
			if (node.left == null && node.right == null) list.Add($"{path}{node.val}");

			if (node.left != null) SearchPath(node.left, $"{path}{node.val}->", list);
			if (node.right != null) SearchPath(node.right, $"{path}{node.val}->",list);
		}

		[Test]
		public void Given_tree_When_find_Then_return()
		{
			var tree = new TreeNode(1)
			{
				left = new TreeNode(2)
				{
					right = new TreeNode(5)
				},
				right = new TreeNode(3)
			};

			var result = BinaryTreePaths(tree);

			Assert.AreEqual("1->2->5", result[0]);
			Assert.AreEqual("1->3", result[1]);
		}

	}
}
