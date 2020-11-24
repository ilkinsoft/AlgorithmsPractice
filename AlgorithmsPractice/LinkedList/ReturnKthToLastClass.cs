using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LinkedList
{
    public class ReturnKthToLastClass
    {
        // solution 1
        // time complexity: O(n)
        // space complexity: O(1)
        public static int ReturnKthToLast(LinkedList<int> linkedList, int k)
        {
            if (k <= 0 || k > linkedList.Count)
                return -1;

            var index = 0;
            var runner = linkedList.First;
            var runner2 = linkedList.First;
            while (runner != null)
            {
                if (index >= k)
                    runner2 = runner2.Next;

                runner = runner.Next;
                index++;
            }
            return runner2.Value;
        }

        // solution 2
        // time complexity: O(n-k)
        // space complexity: O(n-k)
        public static int ReturnKthToLastRecursive(LinkedList<int> linkedList, int k)
        {
            if (k <= 0 || k > linkedList.Count)
                return -1;

            var index = linkedList.Count + 1;
            var runner = linkedList.First;

            return ReturnKthToLastRecursiveBody(runner, k + 1, index);
        }
        public static int ReturnKthToLastRecursiveBody(LinkedListNode<int> runner, int k, int index)
        {
            if (index == k)
                return runner.Value;

            return ReturnKthToLastRecursiveBody(runner.Next, k, --index);
        }
    }
}
