using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
    public class BinaryTreeLevelOrderTraversalII
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();

            List<IList<int>> result = new List<IList<int>>();
            List<TreeNode> nodes = new List<TreeNode>();
            if (root.left != null) nodes.Add(root.left);
            if (root.right != null) nodes.Add(root.right);

            LevelOrder(result, nodes);
            result.Add(new List<int>() { root.val });
            return result;
        }

        private void LevelOrder(List<IList<int>> result, List<TreeNode> nodes)
        {
            if (!nodes.Any()) return;

            var list = nodes.Select(q => q.val).ToList();

            List<TreeNode> nodeList = new List<TreeNode>();
            nodes.ForEach(q =>
            {
                if (q.left != null) nodeList.Add(q.left);
                if (q.right != null) nodeList.Add(q.right);
            });

            LevelOrder(result, nodeList);

            result.Add(list);
        }
    }
}