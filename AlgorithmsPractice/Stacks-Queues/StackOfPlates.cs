using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Stacks_Queues
{
    public class SetOfStacks
    {
        Stack<Stack<int>> stacks = new Stack<Stack<int>>();
        Stack<int> currentStack;
        private readonly int subStackCapacity;
        public SetOfStacks(int capacity)
        {
            subStackCapacity = capacity;
            currentStack = new Stack<int>();
            stacks.Push(currentStack);
        }

        // time complexity: O(1)
        // space complexity: O(1)
        public void push(int value)
        {
            currentStack = stacks.Peek();
            if (currentStack.Count == subStackCapacity)
            {
                currentStack = new Stack<int>();
                stacks.Push(currentStack);
            }
            currentStack.Push(value);
        }

        // time complexity: O(1)
        // space complexity: O(1)
        public int pop()
        {
            if (currentStack.Count == 0)
            {
                stacks.Pop();
                currentStack = stacks.Peek();
            }
            return currentStack.Pop();
        }

        // time complexity: O(n)
        // space complexity: O(1)
        public int popAt(int substackIndex)
        {
            if (substackIndex >= stacks.Count)
                throw new InsufficientExecutionStackException();

            var iteration = 1;
            var targetStack = new Stack<int>();
            foreach (var substack in stacks)
            {
                if (iteration == stacks.Count - substackIndex)
                {
                    targetStack = substack;
                    break;
                }
                iteration++;
            }
            return targetStack.Pop();
        }
        public void PrintStack()
        {
            foreach (var substack in stacks)
            {
                foreach (var stackNode in substack)
                    Console.WriteLine(stackNode);

                Console.WriteLine();
            }
        }
    }
}
