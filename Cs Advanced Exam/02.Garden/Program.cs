using System;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowSize = size[0];
            int colSize = size[1];
            int[,] garden = new int[rowSize, colSize];

            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    garden[row, col] = 0;
                }
            }

            string flowerPosition = Console.ReadLine();

            while (flowerPosition != "Bloom Bloom Plow")
            {
                int[] tokens = flowerPosition.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int flowerRow = tokens[0];
                int flowerCol = tokens[1];

                if (flowerRow < 0 || flowerRow >= rowSize || flowerCol < 0 || flowerCol >= colSize)
                {
                    Console.WriteLine("Invalid coordinates.");
                    flowerPosition = Console.ReadLine();
                    continue;
                }
                else
                {
                    garden[flowerRow, flowerCol] = 1;

                    for (int i = 0; i < colSize; i++)
                    {
                        if (i != flowerCol)
                        {
                            garden[flowerRow, i]++;
                        }
                    }

                    for (int j = 0; j < rowSize; j++)
                    {
                        if (j != flowerRow)
                        {
                            garden[j, flowerCol]++;
                        }
                    }

                }

                flowerPosition = Console.ReadLine();
            }

            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write($"{garden[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
