using System;

namespace TDDArg
{
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            var level = 0;
            var maxLevel = 0;
            var minLevel = 0;

            IsBalanced(root, ref level, ref maxLevel, ref minLevel);

            return Math.Abs(maxLevel - minLevel) <= 1;
        }

        private void IsBalanced(TreeNode node, ref int level, ref int maxLevel, ref int minLevel)
        {
            level++;

            if (node.left == null && node.right == null)
            {
                if (maxLevel == 0) maxLevel = level;
                if (maxLevel == 0) minLevel = level;

                if (level > maxLevel) maxLevel = level;
                if (level < minLevel) minLevel = level;
            }

            if (node.left != null)
                IsBalanced(node.left, ref level, ref maxLevel, ref minLevel);

            if (node.right != null)
                IsBalanced(node.right, ref level, ref maxLevel, ref minLevel);

            level--;
        }
    }
}