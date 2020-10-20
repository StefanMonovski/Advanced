using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInput; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                cars.Add(new Car(inputData[0], double.Parse(inputData[1]), double.Parse(inputData[2])));
            }
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandData = command.Split();
                cars.Find(x => x.Model == commandData[1]).Drive(double.Parse(commandData[2]));
            }
            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
