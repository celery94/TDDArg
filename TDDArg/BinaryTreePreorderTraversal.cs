using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class BinaryTreePreorderTraversal
	{
		public static IList<int> PreorderTraversal(TreeNode root)
		{
			List<int> list = new List<int>();

			if (root != null)
			{
				list.Add(root.val);
				list.AddRange(PreorderTraversal(root.left));
				list.AddRange(PreorderTraversal(root.right));
			}

			return list;
		}
	}
}
