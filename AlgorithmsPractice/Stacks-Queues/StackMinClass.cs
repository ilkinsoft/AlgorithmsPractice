using System;
using System.Collections.Generic;

namespace AlgorithmsPractice.Stacks_Queues
{
    public class StackMinClass
    {
        private StackNode top;
        private int minimum = int.MaxValue;
        private Stack<int> minList = new Stack<int>();
        public int pop()
        {
            if (top == null)
                throw new InsufficientExecutionStackException();

            int item = top.value;
            top = top.next;

            // define min
            if (item == minimum)
                minList.Pop();

            return item;
        }
        public void push(int value)
        {
            StackNode node = new StackNode(value);
            node.next = top;
            top = node;

            // define min
            if(value < minimum)
            {
                minList.Push(value);
                minimum = value;
            }
        }
        public int peek()
        {
            if (top == null)
                throw new InsufficientExecutionStackException();

            return top.value;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public int min()
        {
            if(top == null)
                throw new InsufficientExecutionStackException();

            return minList.Peek();
        }
        public class StackNode
        {
            public int value;
            public StackNode next;
            public StackNode(int value)
            {
                this.value = value;
            }
        }
    }
}
