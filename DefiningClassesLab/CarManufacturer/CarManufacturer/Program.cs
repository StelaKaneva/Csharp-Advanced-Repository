using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMV";
            car.Year = 2005;
            car.FuelConsumption = 12;
            car.FuelQuantity = 2000;

            car.Drive(20);
            car.Drive(20);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
