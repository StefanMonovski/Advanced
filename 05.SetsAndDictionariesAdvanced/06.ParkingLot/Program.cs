using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            HashSet<string> carsParking = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                List<string> inputData = input.Split(", ").ToList();
                string direction = inputData[0];
                string carNumber = inputData[1];
                if (direction == "IN")
                {
                    carsParking.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    carsParking.Remove(carNumber);
                }
            }
            if (carsParking.Count != 0)
            {
                foreach (string item in carsParking)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
