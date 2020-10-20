using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
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
                string model = inputData[0];
                int engineSpeed = int.Parse(inputData[1]);
                int enginePower = int.Parse(inputData[2]);
                int cargoWeight = int.Parse(inputData[3]);
                string cargoType = inputData[4];
                string[] inputPressureData = new string[] { inputData[5], inputData[7], inputData[9], inputData[11] };
                double[] tiresPressure = inputPressureData.Select(double.Parse).ToArray();
                string[] inputAgeData = new string[] { inputData[6], inputData[8], inputData[10], inputData[12] };
                int[] tiresAge = inputAgeData.Select(int.Parse).ToArray();
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tiresPressure, tiresAge);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (Car item in cars)
                {
                    if (item.Cargo.CargoType == "fragile")
                    {
                        foreach (Tire tire in item.Tires)
                        {
                            if (tire.TirePressure < 1)
                            {
                                Console.WriteLine(item.Model);
                                break;
                            }
                        }
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (Car item in cars)
                {
                    if (item.Cargo.CargoType == "flamable" && item.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
