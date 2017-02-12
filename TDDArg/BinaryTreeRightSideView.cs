using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class BinaryTreeRightSideView
	{
		public IList<int> RightSideView(TreeNode root)
		{
			List<int> result = new List<int>();

			FindRightSideView(root, result, 0);

			return result;
		}

		public void FindRightSideView(TreeNode node, List<int> result, int depth)
		{
			if (node == null) return;

			if (result.Count == depth) result.Add(node.val);

			FindRightSideView(node.right, result, depth + 1);
			FindRightSideView(node.left, result, depth + 1);
		}
	}
}
