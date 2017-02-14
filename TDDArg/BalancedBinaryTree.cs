using System;

namespace TDDArg
{
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            int left = Depth(root.left);
            int rigth = Depth(root.right);

            return Math.Abs(left - rigth) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int Depth(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(Depth(root.left), Depth(root.right)) + 1;
        }
    }
}