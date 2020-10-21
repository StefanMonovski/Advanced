using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        public List<Car> Cars { get; set; }
        public int Count { get { return Cars.Count; } set { value = Cars.Count; } }
        private int capacity;

        public Parking(int capacity)
        {
            Cars = new List<Car>(capacity);
            this.capacity = capacity;
        }

        public string AddCar(Car car)
        {
            if (Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count == capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            if (!Cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(Cars.Find(x => x.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return Cars.Find(x => x.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            Cars.RemoveAll(x => registrationNumbers.Contains(x.RegistrationNumber));
        }
    }
}
