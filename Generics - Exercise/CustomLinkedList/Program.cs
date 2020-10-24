using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            list.AddHead(5);
            list.AddHead(2);
            list.AddHead(3);
            list.AddTail(19);
            list.AddTail(20);
            list.AddTail(11);

            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
