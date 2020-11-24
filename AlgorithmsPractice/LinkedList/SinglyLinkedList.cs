using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.LinkedList
{
    public class SinglyLinkedList 
    {
        public int count;
        public Node head;
        public SinglyLinkedList()
        {
            count = 0;
        }
        public class Node
        {
            public int value;
            public Node next;

            public Node(int x)
            {
                this.value = x;
            }
        }

        public void Prepend(int x)
        {
            var node = new Node(x);
            node.next = head;
            head = node;
            count++;
        }
        
        public void Append(int x)
        {
            if(head == null)
            {
                head = new Node(x);
                count++;
                return;
            }
            var current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(x);
            count++;
        }

        public void DeleteByValue(int x)
        {
            if (head == null)
                return;

            if(head.value == x)
            {
                head = head.next;
                count--;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.value == x)
                {
                    current.next = current.next.next;
                    count--;
                    return;
                }
                current = current.next;
            }
        }

        public void PrintList()
        {
            Node runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.value);
                runner = runner.next;
            }
        }
    }
}
