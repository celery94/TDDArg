using System;
namespace TDDArg
{
	public class ConvertSortedArrayToBinarySearchTree
	{
		public static TreeNode SortedArrayToBST(int[] nums)
		{
			if (nums.Length == 0) return null;
			return Append(nums, 0, nums.Length - 1);
		}

		private static TreeNode Append(int[] nums, int s, int e)
		{
			if (s > e) return null;

			var mid = (s + e) / 2;

			var node = new TreeNode(nums[mid]);
			node.left = Append(nums, 0, mid - 1);
			node.right = Append(nums, mid + 1, e);

			return node;
		}
	}
}
