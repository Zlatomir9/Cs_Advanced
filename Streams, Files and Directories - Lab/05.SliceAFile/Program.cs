using System;
using System.IO;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesSize = 4;

            using (FileStream stream = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                long size = stream.Length / 4;

                for (int i = 0; i < piecesSize; i++)
                {
                    using (var pieceStream = new FileStream($"../../../part-{i+1}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[1];
                        int count = 0;
                        while (count < size)
                        {
                            stream.Read(buffer, 0, buffer.Length);
                            pieceStream.Write(buffer, 0, buffer.Length);
                            count+= buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
