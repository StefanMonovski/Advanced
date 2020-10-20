using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; } = "n/a";
        public string Color { get; set; } = "n/a";

        public Car(string[] inputData, Engine engine)
        {
            Engine = engine;
            Model = inputData[0];
            if (inputData.Length == 3 && int.TryParse(inputData[2], out int weight))
            {
                Weight = weight.ToString();
            }
            else if (inputData.Length == 3)
            {
                Color = inputData[2];
            }
            else if (inputData.Length == 4)
            {
                Weight = inputData[2];
                Color = inputData[3];
            }
        }
    }
}
