using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class SumRootToLeafNumbers
	{
		public int SumNumbers(TreeNode root)
		{
			return Sum(root, 0);
		}

		private int Sum(TreeNode root, int s)
		{
			if (root == null) return 0;
			if (root.left == null && root.right == null) return s * 10 + root.val;

			return Sum(root.left, s * 10 + root.val) + Sum(root.right, s * 10 + root.val);
		}
	}
}
