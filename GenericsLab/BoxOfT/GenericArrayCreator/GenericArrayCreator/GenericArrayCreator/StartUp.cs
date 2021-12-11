using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", ArrayCreator.Create(10, "Pesho")));

            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);

        }
    }
}
