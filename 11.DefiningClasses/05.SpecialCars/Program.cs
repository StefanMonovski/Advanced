using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Tire[]> tires = new List<Tire[]>();
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] inputData = input.Split();
                Tire[] currentTires = new Tire[4];
                int counter = 0;
                for (int i = 0; i < inputData.Length; i += 2)
                {
                    Tire tire = new Tire(int.Parse(inputData[i]), double.Parse(inputData[i + 1]));
                    currentTires[counter] = tire;
                    counter++;
                }
                tires.Add(currentTires);
            }
            List<Engine> engines = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] inputData = input.Split();
                int horsePower = int.Parse(inputData[0]);
                double cubicCapacity = double.Parse(inputData[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }
            List<Car> cars = new List<Car>();
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] inputData = input.Split();
                Car car = new Car(inputData[0], inputData[1], int.Parse(inputData[2]), double.Parse(inputData[3]), double.Parse(inputData[4]));
                car.Engine = engines[int.Parse(inputData[5])];
                car.Tires = tires[int.Parse(inputData[6])];
                cars.Add(car);
            }
            List<Car> specialCars = new List<Car>();
            foreach (Car item in cars)
            {
                if (item.Year >= 2017 && item.Engine.HorsePower >= 330 && item.Tires.Sum(x => x.Pressure) >= 9 && item.Tires.Sum(x => x.Pressure) <= 10)
                {
                    item.Drive();
                    specialCars.Add(item);
                }
            }
            foreach (Car item in specialCars)
            {
                Console.WriteLine($"Make: {item.Make}\nModel: {item.Model}\nYear: {item.Year}\nHorsePowers: {item.Engine.HorsePower}\nFuelQuantity: {item.FuelQuantity}");
            }
        }
    }
}
