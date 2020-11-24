using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LinkedList
{
    public class SumListsClass
    {
        // 124 + 331 = 455

        // time complexity: O(n^2)
        // space complexity: O(n)
        public static SinglyLinkedList SumLists(SinglyLinkedList firstList, SinglyLinkedList secondList)
        {
            var runner = firstList.head;
            var runner2 = secondList.head;

            int level = 1;
            int firstNum = 0;
            while (runner != null)
            {
                firstNum = firstNum + level * runner.value;
                level *= 10;
                runner = runner.next;
            }

            level = 1;
            int secondNum = 0;
            while (runner2 != null)
            {
                secondNum = secondNum + level * runner2.value;
                level *= 10;
                runner2 = runner2.next;
            }

            int finalNum = firstNum + secondNum;
            var finalList = new SinglyLinkedList();
            while (finalNum >= 10)
            {
                finalList.Append(finalNum % 10);
                finalNum /= 10;
            }
            finalList.Append(finalNum);
            return finalList;
        }

        // recursive solution
        public static SinglyLinkedList SumListsRecursion(SinglyLinkedList firstList, SinglyLinkedList secondList)
        {
            return SumListsBody(firstList, secondList, new SinglyLinkedList(), 0);
        }

        public static SinglyLinkedList SumListsBody(SinglyLinkedList firstList, SinglyLinkedList secondList, SinglyLinkedList finalList, int temp)
        {
            if (firstList.head == null && secondList.head == null)
                return finalList;

            int firstHead = firstList.head == null ? 0 : firstList.head.value;
            int secondHead = secondList.head == null ? 0 : secondList.head.value;

            int sum = firstHead + secondHead + temp;
            if(sum < 10)
            {
                finalList.Append(sum);
                temp = 0;
            }
            else
            {
                finalList.Append(sum-10);
                temp = 1;
            }

            firstList.head = firstList.head?.next;
            secondList.head = secondList.head?.next;

            return SumListsBody(firstList, secondList, finalList, temp);
        }
    }
}
