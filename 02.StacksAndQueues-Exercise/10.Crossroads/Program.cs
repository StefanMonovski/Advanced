using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            bool crashHappened = false;
            int carsPassedSafely = 0;
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    string currentCar = "";
                    if (cars.Count > 0)
                    {
                        currentCar = cars.Dequeue();
                    }
                    else
                    {
                        continue;
                    }
                    int currentGreenLightSeconds = greenLightSeconds;
                    while (currentGreenLightSeconds > 0)
                    {
                        if (currentCar.Length < currentGreenLightSeconds)
                        {
                            currentGreenLightSeconds -= currentCar.Length;
                            carsPassedSafely++;
                            if (cars.Count > 0)
                            {
                                currentCar = cars.Dequeue();
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (currentCar.Length >= currentGreenLightSeconds && currentCar.Length <= currentGreenLightSeconds + freeWindowSeconds)
                        {
                            currentGreenLightSeconds -= currentCar.Length;
                            carsPassedSafely++;
                        }
                        else if (currentCar.Length > currentGreenLightSeconds + freeWindowSeconds)
                        {
                            crashHappened = true;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[currentGreenLightSeconds + freeWindowSeconds]}.");
                            break;
                        }
                    }
                    if (crashHappened)
                    {
                        break;
                    }
                }
            }
            if (!crashHappened)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassedSafely} total cars passed the crossroads.");
            }
        }
    }
}
