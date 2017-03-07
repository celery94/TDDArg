using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class PathSumII
	{
		public static IList<IList<int>> PathSum(TreeNode root, int sum)
		{
			var result = new List<IList<int>>();
			var currentPath = new List<int>();
			FindPathSum(root, sum, result, currentPath);

			return result;
		}

		private static void FindPathSum(TreeNode node, int sum, List<IList<int>> list, List<int> currentPath)
		{
			if (node == null) return;

			currentPath.Add(node.val);

			if (node.left == null && node.right == null && node.val == sum)
			{
				list.Add(currentPath);
				currentPath.RemoveAt(currentPath.Count - 1);
				return;
			}
			else
			{
				FindPathSum(node.left, sum - node.val, list, currentPath);
				FindPathSum(node.right, sum - node.val, list, currentPath);
			}

			currentPath.RemoveAt(currentPath.Count - 1);
		}

		[Test]
		public void Test()
		{
			var tree = new TreeNode(5)
			{
				left = new TreeNode(4)
				{
					left = new TreeNode(11)
					{
						left = new TreeNode(7),
						right = new TreeNode(2)
					}
				},
				right = new TreeNode(8)
				{
					left = new TreeNode(13),
					right = new TreeNode(4)
					{
						left = new TreeNode(5),
						right = new TreeNode(1)
					}
				}
			};

			var result = PathSum(tree, 22);

			Assert.AreEqual(2, result.Count);
		}
	}
}
