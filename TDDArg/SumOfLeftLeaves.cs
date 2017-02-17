namespace TDDArg
{
    public class SumOfLeftLeaves
    {
        public int FindSumOfLeftLeaves(TreeNode root)
        {
            return Sum(root, false);
        }


        public int Sum(TreeNode node, bool isLeft)
        {
            if (node == null) return 0;

            if (node.left == null && node.right == null && isLeft) return node.val;
            if (node.left == null && node.right == null && !isLeft) return 0;

            return Sum(node.left, true) + Sum(node.right, false);
        }

    }
}