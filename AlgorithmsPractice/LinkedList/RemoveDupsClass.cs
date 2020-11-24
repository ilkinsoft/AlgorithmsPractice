using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LinkedList
{
    public class RemoveDupsClass
    {
        // time complexity: O(n)
        // space complexity: O(n)
        public static LinkedList<int> RemoveDups(LinkedList<int> lnkUnsorted)
        {
            var hashSet = new HashSet<int>();
            LinkedListNode<int> node = lnkUnsorted.First;
            while (node != null)
            {
                if (hashSet.Contains(node.Value))
                    lnkUnsorted.Remove(node.Value);
                else
                    hashSet.Add(node.Value);

                node = node.Next;
            }
            return lnkUnsorted;
        }

        // time complexity: O(n^2)
        // space complexity: O(1)
        public static LinkedList<int> RemoveDups2(LinkedList<int> lnkUnsorted)
        {
            LinkedListNode<int> node = lnkUnsorted.First;
            while (node != null)
            {
                LinkedListNode<int> node2 = lnkUnsorted.First;
                while (node2 != null)
                {
                    if (node2.Value == node.Value && !node2.Equals(node))
                        lnkUnsorted.Remove(node2);

                    node2 = node2.Next;
                }
                node = node.Next;
            }
            return lnkUnsorted;
        }

    }
}
