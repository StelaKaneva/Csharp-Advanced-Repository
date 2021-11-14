using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuelQuantity = 12;
            car.FuelQuantity = 200;

            car.Drive(20);
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
