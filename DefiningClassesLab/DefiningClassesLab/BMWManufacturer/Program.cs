using System;
using CarManufacturer;
namespace BMWManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.Model);
        }
    }
}
