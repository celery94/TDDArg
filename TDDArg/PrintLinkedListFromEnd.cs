using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class PrintLinkedListFromEnd
	{
		public static List<int> Print(ListNode root)
		{
			Stack<int> stack = new Stack<int>();

			while (root != null)
			{
				stack.Push(root.val);
				root = root.next;
			}

			List<int> result = new List<int>();
			while (stack.Count > 0)
			{
				result.Add(stack.Pop());
			}

			return result;
		}
	}
}
