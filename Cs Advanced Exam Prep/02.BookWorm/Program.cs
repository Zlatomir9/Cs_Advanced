using System;
using System.Drawing;
using System.Text;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        if (matrix[playerRow - 1, playerCol] != '-')
                        {
                            sb.Append(matrix[playerRow - 1, playerCol]);
                            matrix[playerRow, playerCol] = '-';
                            playerRow -= 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow -= 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                    }
                    else if (playerRow - 1 < 0)
                    {
                        if (sb.Length > 0)
                        {
                            int index = sb.Length - 1;
                            sb.Remove(index, 1);
                        }
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 < size)
                    {
                        if (matrix[playerRow + 1, playerCol] != '-')
                        {
                            sb.Append(matrix[playerRow + 1, playerCol]);
                            matrix[playerRow, playerCol] = '-';
                            playerRow += 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerRow += 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                    }
                    else if (playerRow + 1 >= size)
                    {
                        if (sb.Length > 0)
                        {
                            int index = sb.Length - 1;
                            sb.Remove(index, 1);
                        }
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        if (matrix[playerRow, playerCol - 1] != '-')
                        {
                            sb.Append(matrix[playerRow, playerCol - 1]);
                            matrix[playerRow, playerCol] = '-';
                            playerCol -= 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol -= 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                    }
                    else if (playerCol - 1 < 0)
                    {
                        if (sb.Length > 0)
                        {
                            int index = sb.Length - 1;
                            sb.Remove(index, 1);
                        }
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 < size)
                    {
                        if (matrix[playerRow, playerCol + 1] != '-')
                        {
                            sb.Append(matrix[playerRow, playerCol + 1]);
                            matrix[playerRow, playerCol] = '-';
                            playerCol += 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = '-';
                            playerCol += 1;
                            matrix[playerRow, playerCol] = 'P';
                        }
                    }
                    else if (playerCol + 1 >= size)
                    {
                        if (sb.Length > 0)
                        {
                            int index = sb.Length - 1;
                            sb.Remove(index, 1);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sb);
            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix) 
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
    }
}
