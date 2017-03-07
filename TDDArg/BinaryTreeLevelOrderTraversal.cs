using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class BinaryTreeLevelOrderTraversal
	{
		public IList<IList<int>> LevelOrder(TreeNode root)
		{
			if (root == null) return new List<IList<int>>();

			List<IList<int>> result = new List<IList<int>>()
			{
				new List<int>() {root.val }
			};
			List<TreeNode> nodes = new List<TreeNode>();
			if (root.left != null) nodes.Add(root.left);
			if (root.right != null) nodes.Add(root.right);

			LevelOrder(result, nodes);

			return result;
		}

		private void LevelOrder(List<IList<int>> result, List<TreeNode> nodes)
		{
			if (!nodes.Any()) return;

			var list = nodes.Select(q => q.val).ToList();
			result.Add(list);

			List<TreeNode> nodeList = new List<TreeNode>();
			nodes.ForEach(q =>
			{
				if (q.left != null) nodeList.Add(q.left);
				if (q.right != null) nodeList.Add(q.right);
			});

			LevelOrder(result, nodeList);
		}

		public IList<IList<int>> LevelOrderII(TreeNode root)
		{
			if (root == null) return new List<IList<int>>();

			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			var result = new List<IList<int>>();
			while (queue.Count > 0)
			{
				var size = queue.Count;
				List<int> list = new List<int>();
				for (int i = 0; i < size; i++)
				{
					var node = queue.Dequeue();
					list.Add(node.val);
					if (node.left != null)
						queue.Enqueue(node.left);
					if (node.right != null)
						queue.Enqueue(node.right);
				}

				result.Add(list);
			}

			return result;
		}
	}
}