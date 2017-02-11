﻿using System;
namespace TDDArg
{
	public class MaximumDepthOfBinaryTree
	{
		public static int MaxDepth(TreeNode root)
		{
			if (root == null) return 0;
			return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
		}
	}
}
