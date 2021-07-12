using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightInterval = int.Parse(Console.ReadLine());
            int freeWindowInterval = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            bool crash = false;
            string crashedCar = String.Empty;
            int hitIndex = -1;
            int passedCars = 0;

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int currentGreenLight = greenLightInterval;

                    while (cars.Any())
                    {
                        string currentCar = cars.Peek();
                        int carLength = currentCar.Length;

                        if (carLength < currentGreenLight)
                        {
                            currentGreenLight -= carLength;
                            cars.Dequeue();
                            passedCars++;
                        }
                        else
                        {
                            carLength -= currentGreenLight;

                            if (carLength <= freeWindowInterval)
                            {
                                cars.Dequeue();
                                passedCars++;
                            }
                            else
                            {
                                crash = true;
                                crashedCar = currentCar;
                                hitIndex = currentGreenLight + freeWindowInterval;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                if (crash)
                {
                    break;
                }
            }

            if (crash)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
