using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var scale = new EqualityScale<int>(6, 6);
            Console.WriteLine(scale.AreEqual());
        }
    }
}
