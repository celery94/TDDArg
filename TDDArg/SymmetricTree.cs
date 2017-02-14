using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDArg
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            return left == null && right == null ||
                (left?.val == right?.val && IsSymmetric(left?.left, right?.right) && IsSymmetric(left?.right, right?.left));
        }
    }
}
