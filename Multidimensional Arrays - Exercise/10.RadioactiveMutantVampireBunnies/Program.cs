using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            ReadMatrix(matrix);

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] moves = Console.ReadLine().ToCharArray();

            bool isWinner = false;
            bool isDead = false;

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'L')
                {
                    if (playerCol - 1 >= 0 && matrix[playerRow, playerCol - 1] != 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerCol = playerCol - 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else if (playerCol - 1 < 0)
                    {
                        matrix[playerRow, playerCol] = '.';
                        isWinner = true;
                    }
                    else if (matrix[playerRow, playerCol - 1] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerCol = playerCol - 1;
                        isDead = true;
                    }
                }
                if (moves[i] == 'R')
                {
                    if (playerCol + 1 < cols && matrix[playerRow, playerCol + 1] != 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerCol = playerCol + 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else if (playerCol + 1 >= cols)
                    {
                        matrix[playerRow, playerCol] = '.';
                        isWinner = true;
                    }
                    else if (matrix[playerRow, playerCol + 1] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerCol = playerCol + 1;
                        isDead = true;
                    }
                }
                if (moves[i] == 'U')
                {
                    if (playerRow - 1 >= 0 && matrix[playerRow - 1, playerCol] != 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = playerRow - 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else if (playerRow - 1 < 0)
                    {
                        matrix[playerRow, playerCol] = '.';
                        isWinner = true;
                    }
                    else if (matrix[playerRow - 1, playerCol] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = playerRow - 1;
                        isDead = true;
                    }
                }
                if (moves[i] == 'D')
                {
                    if (playerRow + 1 < rows && matrix[playerRow + 1, playerCol] != 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = playerRow + 1;
                        matrix[playerRow, playerCol] = 'P';
                    }
                    else if (playerRow + 1 >= rows)
                    {
                        matrix[playerRow, playerCol] = '.';
                        isWinner = true;
                    }
                    else if (matrix[playerRow + 1, playerCol] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = playerRow + 1;
                        isDead = true;
                    }
                }

                Queue<int> bunnies = new Queue<int>();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunnies.Enqueue(row);
                            bunnies.Enqueue(col);
                        }
                    }
                }

                while (bunnies.Count > 0)
                {
                    int row = bunnies.Dequeue();
                    int col = bunnies.Dequeue();

                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1, col] == '.')
                        {
                            matrix[row - 1, col] = 'B';
                        }
                        else if (matrix[row - 1, col] == 'P')
                        {
                            matrix[row - 1, col] = 'B';
                            isDead = true;
                        }
                    }
                    if (row + 1 < rows)
                    {
                        if (matrix[row + 1, col] == '.')
                        {
                            matrix[row + 1, col] = 'B';
                        }
                        else if (matrix[row + 1, col] == 'P')
                        {
                            matrix[row + 1, col] = 'B';
                            isDead = true;
                        }
                    }
                    if (col - 1 >= 0)
                    {
                        if (matrix[row, col - 1] == '.')
                        {
                            matrix[row, col - 1] = 'B';
                        }
                        else if (matrix[row, col - 1] == 'P')
                        {
                            matrix[row, col - 1] = 'B';
                            isDead = true;
                        }
                    }
                    if (col + 1 < cols)
                    {
                        if (matrix[row, col + 1] == '.')
                        {
                            matrix[row, col + 1] = 'B';
                        }
                        else if (matrix[row, col + 1] == 'P')
                        {
                            matrix[row, col + 1] = 'B';
                            isDead = true;
                        }
                    }
                }
                if (isDead || isWinner)
                {
                    break;
                }
            }

            if (isDead)
            {
                PrintMatrix(matrix);
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            else if (isWinner)
            {
                PrintMatrix(matrix);
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
