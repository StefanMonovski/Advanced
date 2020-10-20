using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double[] tiresPressure, int[] tiresAge)
        {
            Model = model;
            Engine = new Engine() { EngineSpeed = engineSpeed, EnginePower = enginePower };
            Cargo = new Cargo() { CargoWeight = cargoWeight, CargoType = cargoType };
            Tires = new Tire[4];
            Tires[0] = new Tire() { TirePressure = tiresPressure[0], TireAge = tiresAge[0] };
            Tires[1] = new Tire() { TirePressure = tiresPressure[1], TireAge = tiresAge[1] };
            Tires[2] = new Tire() { TirePressure = tiresPressure[2], TireAge = tiresAge[2] };
            Tires[3] = new Tire() { TirePressure = tiresPressure[3], TireAge = tiresAge[3] };
        }
    }

    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

    }

    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

    }

    class Tire
    {
        public double TirePressure { get; set; }
        public int TireAge { get; set; }

    }
}
