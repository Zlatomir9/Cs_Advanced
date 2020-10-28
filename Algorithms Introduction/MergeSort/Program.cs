using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> sorted = MergeSort(arr.ToList());
            Console.WriteLine(String.Join(' ', sorted));
        }

        private static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            int middle = list.Count / 2;
            List<int> left = MergeSort(list.GetRange(0, middle));
            List<int> right = MergeSort(list.GetRange(middle, list.Count - middle));

            return CombineArrays(left, right);
        }

        private static List<int> CombineArrays(List<int> left, List<int> right) 
        {
            List<int> sorted = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    sorted.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    sorted.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            for (int i = leftIndex; i < left.Count; i++)
            {
                sorted.Add(left[i]);
            }

            for (int i = rightIndex; i < right.Count; i++)
            {
                sorted.Add(right[i]);
            }

            return sorted;
        }
    }
}
