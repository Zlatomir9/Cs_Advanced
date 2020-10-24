using System;
using System.Linq;

namespace _01.ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = new ListyIterator<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splittedCommand = command.Split();

                if (splittedCommand[0] == "Create")
                {
                    iterator = new ListyIterator<string>(splittedCommand.Skip(1).ToArray());
                }
                else if (splittedCommand[0] == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (splittedCommand[0] == "Print")
                {
                    try
                    {
                        iterator.Print();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }
                else if (splittedCommand[0] == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }


                command = Console.ReadLine();
            }
        }
    }
}
