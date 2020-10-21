using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Make: {Make}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"HorsePower: {HorsePower}");
            output.AppendLine($"RegistrationNumber: {RegistrationNumber}");
            return output.ToString().Trim();
        }
    }
}
