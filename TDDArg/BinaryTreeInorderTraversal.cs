using System.Collections.Generic;

namespace TDDArg
{
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(root);

            while (root.left != null)
            {
                stack.Push(root.left);
                root = root.left;
            }

            List<int> result = new List<int>();
            while (stack.Count > 0)
            {
                var item = stack.Pop();
                result.Add(item.val);

                if (item.right != null)
                {
                    stack.Push(item.right);

                    var left = item.right.left;
                    while (left != null)
                    {
                        stack.Push(left);
                        left = left.left;
                    }
                }
            }

            return result;
        }
    }
}