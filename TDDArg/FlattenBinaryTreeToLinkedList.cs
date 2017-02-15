namespace TDDArg
{
    /// <summary>
    /// 主要的解决方案还是用一个指针记录平板化后的最后一个节点在哪里
    /// </summary>
    public class FlattenBinaryTreeToLinkedList
    {
        private static TreeNode pre = null;
        public static void Flatten(TreeNode root)
        {
            if (root == null) return;
            var left = root.left;
            var right = root.right;

            if (left != null)
            {
                root.right = left;
                root.left = null;
                pre = root.right;
                Flatten(left);
            }

            if (right != null)
            {
                if (pre == null)
                {
                    root.right = right;
                    root.left = null;
                    pre = root.right;
                }
                else
                {
                    pre.right = right;
                    pre.left = null;
                    pre = pre.right;
                }
                Flatten(right);
            }
        }
    }
}