using System;
namespace TDDArg
{
	public class InsertNodeInABinarySearchTree
	{
		public TreeNode InsertNode(TreeNode root, TreeNode node)
		{
			if (root == null) return node;

			if (root.val > node.val)
			{
				root.left = InsertNode(root.left, node);
			}
			else
			{
				root.right = InsertNode(root.right, node);
			}

			return root;
		}

		public TreeNode InsertNodeII(TreeNode root, TreeNode node)
		{
			if (root == null) return node;
			if (node == null) return root;

			var head = root;
			while (root != null)
			{
				if (root.val >= node.val && root.left == null)
				{
					root.left = node;
					break;
				}
				else if (root.val < node.val && root.right == null)
				{
					root.right = node;
					break;
				}
				else if (root.val >= node.val)
				{
					root = root.left;
				}
				else
				{
					root = root.right;
				}
			}

			return head;
		}
	}
}
