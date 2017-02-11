using System;
namespace TDDArg
{
	public class MinimumDepthOfBinaryTree
	{
		public int MinDepth(TreeNode root)
		{
			if (root == null) return 0;

			if (root.left == null) return 1 + Min(root.right);
			if (root.right == null) return 1 + Min(root.right);

			return 1 + Math.Min(Min(root.left), Min(root.right));
		}

		private int Min(TreeNode root) { 
			if (root == null) return 0;

			return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
		}
	}
}
