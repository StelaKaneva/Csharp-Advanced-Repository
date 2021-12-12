using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string personFullName = $"{firstTokens[0]} {firstTokens[1]}";
            string personAddress = firstTokens[2];
            Tuple<string, string> personInfo = new Tuple<string, string>(personFullName, personAddress);
           
            string[] secondTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string personName = secondTokens[0];
            int personLitersOfBeer = int.Parse(secondTokens[1]);
            Tuple<string, int> personBeerInfo= new Tuple<string, int>(personName, personLitersOfBeer);

            string[] thirdTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<int, double> numbers = new Tuple<int, double>(int.Parse(thirdTokens[0]), double.Parse(thirdTokens[1]));

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeerInfo);
            Console.WriteLine(numbers);
        }
    }
}
