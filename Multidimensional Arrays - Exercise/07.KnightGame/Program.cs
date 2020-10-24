using System;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[size, size];

            ReadMatrix(chessBoard);

            int countReplaced = 0;

            while (true)
            {
                int maxAttacks = 0;
                int maxRow = 0;
                int maxCol = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int attacksCount = 0;


                        if (currentSymbol == 'K')
                        {
                            if (IsInside(chessBoard, row - 2, col + 1) && (chessBoard[row - 2, col + 1] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row - 2, col - 1) && (chessBoard[row - 2, col - 1] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row + 1, col + 2) && (chessBoard[row + 1, col + 2] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row + 1, col - 2) && (chessBoard[row + 1, col - 2] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row - 1, col + 2) && (chessBoard[row - 1, col + 2] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row - 1, col - 2) && (chessBoard[row - 1, col - 2] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row + 2, col - 1) && (chessBoard[row + 2, col - 1] == 'K'))
                            {
                                attacksCount++;
                            }
                            if (IsInside(chessBoard, row + 2, col + 1) && (chessBoard[row + 2, col + 1] == 'K'))
                            {
                                attacksCount++;
                            }

                            if (attacksCount > maxAttacks)
                            {
                                maxAttacks = attacksCount;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[maxRow, maxCol] = '0';
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
        }

        private static void ReadMatrix(char[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = rowData[col];
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0)
                && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
        }
    }
}
