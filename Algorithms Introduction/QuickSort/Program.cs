using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = arr.ToList();
            QuickSort(list, 0, list.Count - 1);
            Console.WriteLine(String.Join(' ', list));
        }

        static void QuickSort(List<int> arr, int left, int right)
        {
            if (left < right)
            {
                var partitionIndex = Partition(arr, left, right);
                QuickSort(arr, left, partitionIndex);
                QuickSort(arr, partitionIndex + 1, right);
            }
        }

        static int Partition(List<int> arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i++;
                }
                while (arr[i] < pivot);
                do
                {
                    j--;
                }
                while (arr[j] > pivot);

                if (i >= j)
                {
                    return j;
                }

                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
