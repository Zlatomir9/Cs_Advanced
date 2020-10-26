using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(arr, num, 0, arr.Length));
        }

        private static int BinarySearch(int[] arr, int num, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = (start + end) / 2;

            if (num < arr[mid])
            {
                return BinarySearch(arr, num, start, mid - 1);
            }
            else if (num > arr[mid])
            {
                return BinarySearch(arr, num, mid + 1, arr.Length);
            }
            else
            {
                return mid;
            }
        }
    }
}
