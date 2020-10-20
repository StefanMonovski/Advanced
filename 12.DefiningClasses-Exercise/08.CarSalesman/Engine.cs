using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; } = "n/a";
        public string Efficiency { get; set; } = "n/a";

        public Engine() { }
        public Engine(string[] inputData)
        {
            Model = inputData[0];
            Power = int.Parse(inputData[1]);
            if (inputData.Length == 3 && int.TryParse(inputData[2], out int displacement))
            {
                Displacement = displacement.ToString();
            }
            else if (inputData.Length == 3)
            {
                Efficiency = inputData[2];
            }
            else if (inputData.Length == 4)
            {
                Displacement = inputData[2];
                Efficiency = inputData[3];
            }
        }
    }
}
