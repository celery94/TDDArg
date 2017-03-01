using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class FindBottomLeftTreeValue
	{
		public int FindBottomLeftValue(TreeNode root)
		{
			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			int result = 0;
			while (queue.Count > 0)
			{
				result = queue.Peek().val;

				var size = queue.Count;
				for (int i = 0; i < size; i++)
				{
					var node = queue.Dequeue();

					if (node.left != null) queue.Enqueue(node.left);
					if (node.right != null) queue.Enqueue(node.right);
				}
			}

			return result;
		}
	}
}
