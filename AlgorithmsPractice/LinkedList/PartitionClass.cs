using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LinkedList
{
    public class PartitionClass
    {
        // time complexity: O(n)
        // space complexity: O(n)
        public static LinkedList<int> Partition(LinkedList<int> linkedList, int partition)
        {
            // 3 => 5 => 8 => 5 => 10 => 2 => 1

            var lessList = new LinkedList<int>();
            var greaterList = new LinkedList<int>();

            var runner = linkedList.First;
            while (runner != null)
            {
                if (runner.Value < partition)
                    lessList.AddLast(runner.Value);
                else
                    greaterList.AddLast(runner.Value);

                runner = runner.Next;
            }

            foreach (var node in greaterList)
                lessList.AddLast(node);

            return lessList;
        }
    }
}
