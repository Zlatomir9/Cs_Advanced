using System;

namespace _01.CustomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(5);
            list.Add(4);
            list.Add(3);
            list.Add(2);

            list.RemoveAt(1);

            list.Insert(1, 10);

            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.Contains(11));

            list.Swap(0, 3);
            
        }
    }
}
