using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                
                cars.Add(car);
            }

            string inputDrive = Console.ReadLine();

            while (inputDrive != "End")
            {
                string[] driveInfo = inputDrive.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = driveInfo[1];
                int amountOfKm = int.Parse(driveInfo[2]);

                Car car = GetCar(cars, model);
                //Car car = cars.FirstOrDefault(x => x.Model == model);

                car.Drive(amountOfKm);

                inputDrive = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        private static Car GetCar(List<Car> cars, string model)
        {
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }

            return null;
        }
    }
}
