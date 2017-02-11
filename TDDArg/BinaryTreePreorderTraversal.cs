using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class BinaryTreePreorderTraversal
	{
		public static IList<int> PreorderTraversal(TreeNode root)
		{
			List<int> list = new List<int>();

			Stack<TreeNode> stack = new Stack<TreeNode>();
			stack.Push(root);
			while (stack.Count > 0)
			{
				var current = stack.Pop();

				if (current != null)
				{
					list.Add(current.val);
					stack.Push(current.right);
					stack.Push(current.left);
				}
			}

			return list;
		}
	}
}
