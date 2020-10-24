using System;
using System.Text;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string fullName = $"{firstInput[0]} {firstInput[1]}";
            string street = firstInput[2];
            StringBuilder city = new StringBuilder();

            if (firstInput.Length == 4)
            {
                city.Append(firstInput[3]);
            }
            else
            {
                for (int i = 3; i < firstInput.Length; i++)
                {
                    city.Append(firstInput[i] + " ");
                }
                city.ToString().TrimEnd();
            }

            Threeuple<string, string, StringBuilder> personInfo = new Threeuple<string, string, StringBuilder>(fullName, street, city);

            string[] secondInput = Console.ReadLine().Split();
            string firstName = secondInput[0];
            int beerLiters = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2] == "drunk" ? true : false;

            Threeuple<string, int, bool> beersInfo = new Threeuple<string, int, bool>(firstName, beerLiters, isDrunk);

            string[] thirdInput = Console.ReadLine().Split();
            string name = thirdInput[0];
            double accountBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Threeuple<string, double, string> bankInfo = new Threeuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine(personInfo);
            Console.WriteLine(beersInfo);
            Console.WriteLine(bankInfo);
        }
    }
}
