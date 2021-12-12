using System;

namespace ThreeupleSecond
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string town = String.Empty;
            if (input.Length > 4)
            {
                town = $"{input[3]} {input[4]}";
                
            }
            else
            {
                town = input[3];
            }
            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(input[0] + " " + input[1], input[2], town);
            Console.WriteLine(tuple1);

            input = Console.ReadLine().Split();
            bool isDrunk = input[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), isDrunk);
            Console.WriteLine(tuple2);

            input = Console.ReadLine().Split();
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
            Console.WriteLine(tuple3);
        }
    }
}
