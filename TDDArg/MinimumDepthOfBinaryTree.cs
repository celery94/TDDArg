using System;
namespace TDDArg
{
	public class MinimumDepthOfBinaryTree
	{
		public int MinDepth(TreeNode root)
		{
			if (root == null) return 0;

			if (root.left == null && root.right == null)
				return 1;
			else if (root.left == null)
				return 1 + MinDepth(root.right);

			else if (root.right == null)
				return 1 + MinDepth(root.left);

			return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
		}
	}
}
