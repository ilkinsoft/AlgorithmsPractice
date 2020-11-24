using AlgorithmsPractice.LinkedList;
using AlgorithmsPractice.Stacks_Queues;
using AlgorithmsPractice.Strings_Arrays;
using System;
using System.Collections.Generic;

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
            var stack = new StackMinClass();
            stack.push(7);
            stack.push(17);
            stack.push(32);
            stack.push(3);
            stack.push(19);
            stack.push(8);
            stack.pop();
            stack.pop();
            stack.pop();
            Console.WriteLine(stack.min());

            Console.ReadKey();
        }
    }
}
