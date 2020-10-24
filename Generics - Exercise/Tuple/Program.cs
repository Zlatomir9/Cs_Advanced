using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string fullName = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];

            Tuple<string, string> personInfo = new Tuple<string, string>(fullName, adress);

            string[] secondInput = Console.ReadLine().Split();
            string firstName = secondInput[0];
            int beers = int.Parse(secondInput[1]);

            Tuple<string, int> beersInfo = new Tuple<string, int>(firstName, beers);

            string[] thirdInput = Console.ReadLine().Split();
            int first = int.Parse(thirdInput[0]);
            double second = double.Parse(thirdInput[1]);

            Tuple<int, double> numbersInfo = new Tuple<int, double>(first, second);

            Console.WriteLine(personInfo);
            Console.WriteLine(beersInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
