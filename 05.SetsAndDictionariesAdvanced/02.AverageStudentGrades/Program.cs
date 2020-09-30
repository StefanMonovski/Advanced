using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < totalStudents; i++)
            {
                List<string> currentStudentData = Console.ReadLine().Split().ToList();
                string currentStudent = currentStudentData[0];
                decimal currentGrade = decimal.Parse(currentStudentData[1]);
                if (studentGrades.ContainsKey(currentStudentData[0]))
                {
                    studentGrades[currentStudent].Add(currentGrade);
                }
                else
                {
                    studentGrades.Add(currentStudent, new List<decimal>());
                    studentGrades[currentStudent].Add(currentGrade);
                }
            }
            foreach (var item in studentGrades)
            {
                decimal currentStudentAverage = studentGrades[item.Key].Average();
                Console.Write($"{item.Key} -> ");
                foreach (decimal grade in studentGrades[item.Key])
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {currentStudentAverage:f2})");
            }
        }
    }
}
