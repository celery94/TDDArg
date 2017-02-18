using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class MinStack
	{
		Stack<int> stack;
		Stack<int> minStack;

		/** initialize your data structure here. */
		public MinStack()
		{
			stack = new Stack<int>();
			minStack = new Stack<int>();
		}

		public void Push(int x)
		{
			stack.Push(x);

			if (minStack.Count == 0)
			{
				minStack.Push(x);
			}
			else {
				if (x < minStack.Peek())
				{
					minStack.Push(x);
				}
				else {
					minStack.Push(minStack.Peek());
				}
			}
		}

		public void Pop()
		{
			stack.Pop();
			minStack.Pop();
		}

		public int Top()
		{
			return stack.Peek();
		}

		public int GetMin()
		{
			return minStack.Peek();
		}
	}
}
