using System;

namespace ImplementingLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            for (int i = 0; i < 5; i++)
            {
                list.AddHead(new Node(i));
            }

            for (int i = 0; i < 5; i++)
            {
                list.AddLast(new Node(i));
            }

            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveFirst();

            list.RemoveLast();
            list.RemoveLast();
            list.RemoveLast();

            list.PrintList();

            Console.WriteLine(list.ToArray().Length);

            //LinkedList list = new LinkedList();

            //for (int i = 0; i < 10; i++)
            //{
            //    list.AddHead(new Node(i));
            //}

            //list.PrintList();

            //Console.WriteLine($"Popped: {list.RemoveFirst().Value}");
            //Console.WriteLine($"Popped: {list.RemoveFirst().Value}");
            //Console.WriteLine($"Popped: {list.RemoveFirst().Value}");
            //Console.WriteLine($"Popped: {list.RemoveFirst().Value}");

            //list.ReversePrintList();

            //Node currentHead = list.Head;

            //Console.WriteLine(currentHead.Value);
            //Console.WriteLine(currentHead.Next.Value);
            //Console.WriteLine(currentHead.Next.Next.Value);
            //Console.WriteLine(currentHead.Next.Next.Next.Value);

            //while (currentHead != null)
            //{
            //    Console.WriteLine(currentHead.Value);
            //    currentHead = currentHead.Next;
            //}

            //Node head = new Node(0);
            //Node second = new Node(1);
            //head.Next = second;
            //Node third = new Node(2);
            //second.Next = third;
            //Node fourth = new Node(3);
            //third.Next = fourth;

            //Node currentHead = head;
            //while (currentHead != null)
            //{
            //    Console.WriteLine(currentHead.Value);
            //    currentHead = currentHead.Next;
            //}
        }
    }
}
