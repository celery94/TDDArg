using System;
using System.Collections.Generic;

namespace TDDArg
{
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
				currentPath.Remove(currentPath.Count - 1);
				return;
			}
			else
			{
				FindPathSum(node.left, sum - node.val, list, currentPath);
				FindPathSum(node.right, sum - node.val, list, currentPath);
			}

			currentPath.Remove(currentPath.Count - 1);
		}
	}
}
