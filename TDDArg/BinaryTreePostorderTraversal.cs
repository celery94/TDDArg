using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class BinaryTreePostorderTraversal
	{
		public static IList<int> PostorderTraversal(TreeNode root)
		{
			List<int> list = new List<int>();
			Traversal(root, list);
			return list;
		}

		private static void Traversal(TreeNode node, List<int> list)
		{
			if (node == null) return;
			Traversal(node.left, list);
			Traversal(node.right, list);
			list.Add(node.val);
		}
	}
}
