using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCarsPassGreen = int.Parse(Console.ReadLine());
            int totalCarsPassGreen = 0;
            Queue<string> cars = new Queue<string>();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    int counter = 0;
                    while (counter < numberCarsPassGreen && cars.Count != 0)
                    {
                        string car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        totalCarsPassGreen++;
                        counter++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
            Console.WriteLine($"{totalCarsPassGreen} cars passed the crossroads.");
        }
    }
}
