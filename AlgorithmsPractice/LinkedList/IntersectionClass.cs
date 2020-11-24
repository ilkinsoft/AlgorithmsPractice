using static AlgorithmsPractice.LinkedList.SinglyLinkedList;

namespace AlgorithmsPractice.LinkedList
{
    public class IntersectionClass
    {
        // time complexity: O(a + b + (a-b))
        // space complexity: O(1)
        public static Node Intersection(SinglyLinkedList firstList, SinglyLinkedList secondlist)
        {
            firstList = ReverseLinkedList(firstList);
            secondlist = ReverseLinkedList(secondlist);

            var runner = firstList.head;
            var runner2 = secondlist.head;
            Node intersection = null;

            while (runner != null)
            {
                if (runner != runner2)
                    break;

                intersection = runner;
                runner = runner.next;
                runner2 = runner2.next;
            }
            return intersection;
        }

        public static SinglyLinkedList ReverseLinkedList(SinglyLinkedList linkedList)
        {
            var runner = linkedList.head;
            var runner2 = linkedList.head.next;

            while (runner != null)
            {
                runner2.next = runner;
                runner = runner.next;
            }
            return linkedList;
        }
    }
}
