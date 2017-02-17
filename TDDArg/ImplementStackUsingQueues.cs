using System;
using System.Collections.Generic;

namespace TDDArg
{
    public class MyStack
    {
        private Queue<int> _queue1;
        private Queue<int> _queue2;

        /** Initialize your data structure here. */
        public MyStack()
        {
            _queue1 = new Queue<int>();
            _queue2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            if (_queue1.Count == 0)
                _queue2.Enqueue(x);
            else
                _queue1.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (Empty()) throw new Exception("Stack is empty");

            if (_queue1.Count == 0)
            {
                while (_queue2.Count > 1)
                {
                    _queue1.Enqueue(_queue2.Dequeue());
                }

                return _queue2.Dequeue();
            }
            else
            {
                while (_queue1.Count > 1)
                {
                    _queue2.Enqueue(_queue1.Dequeue());
                }

                return _queue1.Dequeue();
            }
        }

        /** Get the top element. */
        public int Top()
        {
            if (Empty()) throw new Exception("Stack is empty");

            int top;
            if (_queue1.Count == 0)
            {
                while (_queue2.Count > 1)
                {
                    _queue1.Enqueue(_queue2.Dequeue());
                }

                top = _queue2.Peek();
                _queue1.Enqueue(_queue2.Dequeue());
            }
            else
            {
                while (_queue1.Count > 1)
                {
                    _queue2.Enqueue(_queue1.Dequeue());
                }

                top = _queue1.Peek();
                _queue2.Enqueue(_queue1.Dequeue());
            }

            return top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return _queue1.Count == 0 && _queue2.Count == 0;
        }
    }
}