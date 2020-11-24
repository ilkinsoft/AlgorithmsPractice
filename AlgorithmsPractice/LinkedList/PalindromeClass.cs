using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LinkedList
{
    public class PalindromeClass
    {
        // 1 => 2 => 3 => 12 => 3 => 2 => 1

        // time complexity: O(n)
        // space complexity: O(n)
        public static bool Palindrome(SinglyLinkedList linkedList)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            int halfSize = linkedList.count / 2;
            int iteration = 1;
            int skipIteration = linkedList.count % 2 == 1 ? halfSize + 1 : 0;
            var runner = linkedList.head;
            while (runner != null)
            {
                if (iteration <= halfSize)
                    stack.Push(runner.value);
                else
                {
                    if (iteration != skipIteration)
                        queue.Enqueue(runner.value);
                }
                iteration++;
                runner = runner.next;
            }
            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                    return false;
            }
            return true;
        }
        
        // Recursive solution
        //public static bool PalindromeRecursive(SinglyLinkedList linkedList)
        //{
        //    return PalindromeBody(linkedList);
        //}
        //public static bool PalindromeBody(SinglyLinkedList linkedList)
        //{

        //}
    }
}
