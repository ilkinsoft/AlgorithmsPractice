using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Stacks_Queues
{
    public class MyQueue
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public void add(int data)
        {
            if (stack2.Count > 0)
            {
                foreach (var item in stack2)
                    stack1.Push(stack2.Pop());
            }
            stack1.Push(data);
        }
        public int remove()
        {
            foreach (var item in stack1)
                stack2.Push(stack1.Pop());

            return stack2.Pop();
        }
    }
}
