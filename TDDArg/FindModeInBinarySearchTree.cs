using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class FindModeInBinarySearchTree
	{
		public int[] FindMode(TreeNode root)
		{
			if (root == null) return new int[] { };

			Dictionary<int, int> result = new Dictionary<int, int>();

			Inorder(root, result);

			var max = result.OrderByDescending(q => q.Value).Select(q=>q.Value).FirstOrDefault();

			return result.Where(q => q.Value == max).Select(q => q.Key).ToArray();
		}

		private void Inorder(TreeNode node,Dictionary<int,int> result)
		{
			if (node == null) return;

			if (node.left != null)
				Inorder(node.left, result);

			if (result.ContainsKey(node.val))
			{
				result[node.val]++;
			}
			else
			{
				result.Add(node.val, 1);
			}

			if (node.right != null)
				Inorder(node.right, result);
		}
	}
}
