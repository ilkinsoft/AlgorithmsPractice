﻿using AlgorithmsPractice.LeetCode;
using AlgorithmsPractice.LinkedList;
using AlgorithmsPractice.Stacks_Queues;
using AlgorithmsPractice.Strings_Arrays;
using System;
using System.Collections.Generic;
using static AlgorithmsPractice.LeetCode.MergeSortedListsClass;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsUniqueClass.IsUnique("ssofty"));

            //Console.WriteLine(UrlifyClass.Urlify("Mr Sam Elimov    ", 13));

            //Console.WriteLine(StringCompressionClass.StringCompression("aaabbcc"));

            //var linkedList = new LinkedList<int>();
            //linkedList.AddLast(1);
            //linkedList.AddLast(7);
            //linkedList.AddLast(10);
            //linkedList.AddLast(5);
            //linkedList.AddLast(14);
            //linkedList.AddLast(9);
            //linkedList.AddLast(6);
            //linkedList.AddLast(90);
            //linkedList.AddLast(4);
            //linkedList.AddLast(14);
            //linkedList.AddLast(2);

            //linkedList = RemoveDupsClass.RemoveDups2(linkedList);

            //foreach (var item in linkedList)
            //    Console.WriteLine(item);

            ///
            //Console.WriteLine(ReturnKthToLastClass.ReturnKthToLast(linkedList, 11));
            //Console.WriteLine(ReturnKthToLastClass.ReturnKthToLastRecursive(linkedList, 11));

            //var lnkdList = PartitionClass.Partition(linkedList, 5);
            //foreach (var item in lnkdList)
            //    Console.WriteLine(item);

            //var firstList = new SinglyLinkedList();
            //firstList.Append(4);
            //firstList.Append(2);
            //firstList.Append(1);
            //firstList.Append(1);


            //var secondList = new SinglyLinkedList();
            //secondList.Append(1);
            //secondList.Append(3);
            //secondList.Append(3);

            //SumListsClass.SumLists(firstList, secondList).PrintList();
            //Console.WriteLine();
            //SumListsClass.SumListsRecursion(firstList, secondList).PrintList();

            // TEST Palindrome
            //var linkedList = new SinglyLinkedList();
            //linkedList.Append(3);
            //linkedList.Append(2);
            //linkedList.Append(1);
            //linkedList.Append(100);
            //linkedList.Append(1);
            //linkedList.Append(2);
            //linkedList.Append(3);

            //Console.WriteLine(PalindromeClass.Palindrome(linkedList));

            // TEST StackMin
            //var stack = new StackMinClass();
            //stack.push(7);
            //stack.push(17);
            //stack.push(32);
            //stack.push(3);
            //stack.push(19);
            //stack.push(8);
            //stack.pop();
            //stack.pop();
            //stack.pop();
            //Console.WriteLine(stack.min());

            // TEST SetOfStacks
            //var stack = new SetOfStacks(5);
            //stack.push(1);
            //stack.push(2);
            //stack.push(3);
            //stack.push(4);
            //stack.push(5);

            //stack.push(6);
            //stack.push(7);
            //stack.push(8);
            //stack.push(9);
            //stack.push(10);

            //stack.push(11);
            //stack.push(12);
            //stack.push(13);
            //stack.push(14);
            //stack.push(15);

            //stack.popAt(0);
            //stack.popAt(1);
            //stack.popAt(2);
            //stack.PrintStack();


            // TEST AnimalShelter
            //var stack = new AnimalShelter();
            //stack.enqueue(AnimalShelter.Animal.Cat);
            //stack.enqueue(AnimalShelter.Animal.Cat);
            //stack.enqueue(AnimalShelter.Animal.Dog);
            //stack.enqueue(AnimalShelter.Animal.Cat);
            //stack.enqueue(AnimalShelter.Animal.Dog);
            //stack.enqueue(AnimalShelter.Animal.Cat);
            //stack.dequeueDog();
            //stack.dequeueDog();
            //stack.PrintList();

            // TEST MergeSortedLists
            //var l1 = new ListNode(1).next = new ListNode(2).next = new ListNode(4);
            //var l2 = new ListNode(1).next = new ListNode(3).next = new ListNode(4);
            ////var mergedList = MergeSortedListsClass.MergeTwoLists(l1, l2);
            //while (l1 != null)
            //{
            //    Console.WriteLine(l1.val);
            //    l1 = l1.next;
            //}

            // TEST RemoveDuplicates
            //var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //RemoveDuplicatesClass.RemoveDuplicates(nums);

            // TEST SearchInsertPosition
            var nums = new int[] { 1, 3, 5, 6 };
            int result = SearchInsertPositionClass.SearchInsert(nums, 5);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
