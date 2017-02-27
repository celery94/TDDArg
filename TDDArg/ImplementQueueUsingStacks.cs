using System.Collections;
using System.Collections.Generic;

namespace TDDArg
{
    public class MyQueue
    {
        private Stack<int> stack;
        private Stack<int> stackO;


        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack = new Stack<int>();
            stackO = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (stackO.Count > 0)
            {
                return stackO.Pop();
            }
            else
            {
                while (stack.Count > 0)
                {
                    stackO.Push(stack.Pop());
                }

                return stackO.Pop();
            }
        }

        /** Get the front element. */
        public int Peek()
        {
            if (stackO.Count > 0)
            {
                return stackO.Peek();
            }
            else
            {
                while (stack.Count > 0)
                {
                    stackO.Push(stack.Pop());
                }

                return stackO.Peek();
            }
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack.Count == 0 && stackO.Count == 0;
        }
    }
}