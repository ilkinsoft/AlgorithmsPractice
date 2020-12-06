using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LeetCode
{
    public class MergeSortedListsClass
    {
        //  Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var merged = l1;
            while (l1 != null && l2 != null)
            {
                if (l1.val == l2.val || (l1.val <= l2.val && l1.next != null && l1.next.val >= l2.val))
                {
                    l1.next = new ListNode(l2.val, l1.next);
                    l2 = l2.next;
                }
                l1 = l1.next;
            }
            return l1;
        }
    }
}
