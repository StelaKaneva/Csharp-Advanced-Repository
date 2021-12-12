using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string personFullName = $"{firstTokens[0]} {firstTokens[1]}";
            string personAddress = firstTokens[2];
            string personTown = firstTokens[3];

            if (firstTokens.Length > 4)
            {
                personTown = $"{firstTokens[3]} {firstTokens[4]}";
            }

            Tuple<string, string, string> personInfo = new Tuple<string, string, string>(personFullName, personAddress, personTown);

            string[] secondTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string personName = secondTokens[0];
            int personLitersOfBeer = int.Parse(secondTokens[1]);
            bool isDrunk = true;
            if (secondTokens[2] == "not")
            {
                isDrunk = false;
            }
            Tuple<string, int, bool> personBeerInfo = new Tuple<string, int, bool>(personName, personLitersOfBeer, isDrunk);

            string[] thirdTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstElement = thirdTokens[0];
            double secondElement = double.Parse(thirdTokens[1]);
            string thirdElement = thirdTokens[2];

            Tuple<string, double, string> thirdExample = new Tuple<string, double, string>(firstElement, secondElement, thirdElement);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeerInfo);
            Console.WriteLine(thirdExample);
        }
    }
}
