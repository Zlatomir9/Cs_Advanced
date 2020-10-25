using System;

namespace _02.TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int firsPlayerRow = -1;
            int firsPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'f')
                    {
                        firsPlayerRow = row;
                        firsPlayerCol = col;
                    }
                    else if (rowData[col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string firstPlayerMove = commands[0];
                string secondPlayerMove = commands[1];

                if (firstPlayerMove == "up")
                {
                    if ((firsPlayerRow - 1 >= 0) && (matrix[firsPlayerRow - 1, firsPlayerCol] != 's'))
                    {
                        firsPlayerRow -= 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerRow - 1 < 0) && (matrix[size - 1, firsPlayerCol] != 's'))
                    {
                        firsPlayerRow = size - 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerRow - 1 >= 0) && (matrix[firsPlayerRow - 1, firsPlayerCol] == 's'))
                    {
                        firsPlayerRow -= 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                    else if ((firsPlayerRow - 1 < 0) && (matrix[size - 1, firsPlayerCol] == 's'))
                    {
                        firsPlayerRow = size - 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                }
                else if (firstPlayerMove == "down")
                {
                    if ((firsPlayerRow + 1 < size) && (matrix[firsPlayerRow + 1, firsPlayerCol] != 's'))
                    {
                        firsPlayerRow += 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerRow + 1 >= size) && (matrix[0, firsPlayerCol] != 's'))
                    {
                        firsPlayerRow = 0;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerRow + 1 < size) && (matrix[firsPlayerRow + 1, firsPlayerCol] == 's'))
                    {
                        firsPlayerRow += 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                    else if ((firsPlayerRow + 1 >= size) && (matrix[0, firsPlayerCol] == 's'))
                    {
                        firsPlayerRow = 0;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                }
                else if (firstPlayerMove == "left")
                {
                    if ((firsPlayerCol - 1 >= 0) && (matrix[firsPlayerRow, firsPlayerCol - 1] != 's'))
                    {
                        firsPlayerCol -= 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerCol - 1 < 0) && (matrix[firsPlayerRow, size - 1] != 's'))
                    {
                        firsPlayerCol = size - 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerCol - 1 >= 0) && (matrix[firsPlayerRow, firsPlayerCol - 1] == 's'))
                    {
                        firsPlayerCol -= 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                    else if ((firsPlayerCol - 1 < 0) && (matrix[firsPlayerRow, size - 1] == 's'))
                    {
                        firsPlayerCol = size - 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                }
                else if (firstPlayerMove == "right")
                {
                    if ((firsPlayerCol + 1 < size) && (matrix[firsPlayerRow, firsPlayerCol + 1] != 's'))
                    {
                        firsPlayerCol += 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerCol + 1 >= size) && (matrix[firsPlayerRow, 0] != 's'))
                    {
                        firsPlayerCol = 0;
                        matrix[firsPlayerRow, firsPlayerCol] = 'f';
                    }
                    else if ((firsPlayerCol + 1 < size) && (matrix[firsPlayerRow, firsPlayerCol + 1] == 's'))
                    {
                        firsPlayerCol += 1;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                    else if ((firsPlayerCol + 1 >= size) && (matrix[firsPlayerRow, firsPlayerCol + 1] == 's'))
                    {
                        firsPlayerCol = 0;
                        matrix[firsPlayerRow, firsPlayerCol] = 'x';
                        break;
                    }
                }

                if (secondPlayerMove == "up")
                {
                    if ((secondPlayerRow - 1 >= 0) && (matrix[secondPlayerRow - 1, secondPlayerCol] != 'f'))
                    {
                        secondPlayerRow -= 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerRow - 1 < 0) && (matrix[size - 1, secondPlayerCol] != 'f'))
                    {
                        secondPlayerRow = size - 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerRow - 1 >= 0) && (matrix[secondPlayerRow - 1, secondPlayerCol] == 'f'))
                    {
                        secondPlayerRow -= 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                    else if ((secondPlayerRow - 1 < 0) && (matrix[size - 1, secondPlayerCol] == 'f'))
                    {
                        secondPlayerRow = size - 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                }
                else if (secondPlayerMove == "down")
                {
                    if ((secondPlayerRow + 1 < size) && (matrix[secondPlayerRow + 1, secondPlayerCol] != 'f'))
                    {
                        secondPlayerRow += 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerRow + 1 >= size) && (matrix[0, secondPlayerCol] != 'f'))
                    {
                        secondPlayerRow = 0;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerRow + 1 < size) && (matrix[secondPlayerRow + 1, secondPlayerCol] == 'f'))
                    {
                        secondPlayerRow += 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                    else if ((secondPlayerRow + 1 >= size) && (matrix[0, secondPlayerCol] == 'f'))
                    {
                        secondPlayerRow = 0;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                }
                else if (secondPlayerMove == "left")
                {
                    if ((secondPlayerCol - 1 >= 0) && (matrix[secondPlayerRow, secondPlayerCol - 1] != 'f'))
                    {
                        secondPlayerCol -= 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerCol - 1 < 0) && (matrix[secondPlayerRow, size - 1] != 'f'))
                    {
                        secondPlayerCol = size - 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerCol - 1 >= 0) && (matrix[secondPlayerRow, secondPlayerCol - 1] == 'f'))
                    {
                        secondPlayerCol -= 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                    else if ((secondPlayerCol - 1 < 0) && (matrix[secondPlayerRow, size - 1] == 'f'))
                    {
                        secondPlayerCol = size - 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                }
                else if (secondPlayerMove == "right")
                {
                    if ((secondPlayerCol + 1 < size) && (matrix[secondPlayerRow, secondPlayerCol + 1] != 'f'))
                    {
                        secondPlayerCol += 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerCol + 1 >= size) && (matrix[secondPlayerRow, 0] != 'f'))
                    {
                        secondPlayerCol = 0;
                        matrix[secondPlayerRow, secondPlayerCol] = 's';
                    }
                    else if ((secondPlayerCol + 1 < size) && (matrix[secondPlayerRow, secondPlayerCol + 1] == 'f'))
                    {
                        secondPlayerCol += 1;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                    else if ((secondPlayerCol + 1 >= size) && (matrix[secondPlayerRow, secondPlayerCol + 1] == 'f'))
                    {
                        secondPlayerCol = 0;
                        matrix[secondPlayerRow, secondPlayerCol] = 'x';
                        break;
                    }
                }


                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

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
