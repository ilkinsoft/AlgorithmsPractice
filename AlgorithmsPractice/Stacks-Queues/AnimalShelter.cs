using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.Stacks_Queues
{
    public class AnimalShelter
    {
        public enum Animal { Cat, Dog }

        //public class AnimalNode<Animal>
        //{
        //    public Animal data;
        //    public AnimalNode<Animal> next;
        //    public AnimalNode(Animal animal)
        //    {
        //        this.data = animal;
        //    }
        //}
        private LinkedList<Animal> linkedList = new LinkedList<Animal>();
        public void enqueue(Animal animal)
        {
            var node = new LinkedListNode<Animal>(animal);
            linkedList.AddLast(node);
        }
        public LinkedListNode<Animal> dequeueAny()
        {
            var first = linkedList.First;
            linkedList.RemoveFirst();
            return first;
        }
        public Animal dequeueCat()
        {
            return dequeue(Animal.Cat);
        }
        public Animal dequeueDog()
        {
            return dequeue(Animal.Dog);
        }
        private Animal dequeue(Animal animal)
        {
            LinkedListNode<Animal> node = null;
            var runner = linkedList.First;

            while (runner != null)
            {
                if (runner.Value == animal)
                {
                    node = runner;
                    break;
                }
                runner = runner.Next;
            }
            if (node == null)
                throw new InsufficientExecutionStackException();
            else
                linkedList.Remove(node);

            return node.Value;
        }
        public void PrintList()
        {
            var runner = linkedList.First;
            while (runner != null)
            {
                Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }
    }
}
