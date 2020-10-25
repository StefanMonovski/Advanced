using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {
        public List<Student> Students { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Students.Count; } set { value = Students.Count; } }

        public Classroom(int capacity)
        {
            Students = new List<Student>();
            Capacity = capacity;
        }

        public string RegisterStudent(Student student)
        {
            if (Count + 1 <= Capacity)
            {
                Students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            if (Students.Any(x => x.FirstName == firstName && x.LastName == lastName))
            {
                Student removeStudent = Students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                Students.Remove(removeStudent);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            if (!Students.Any(x => x.Subject == subject))
            {
                return "No students enrolled for the subject";
            }
            else
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine($"Subject: {subject}");
                output.AppendLine("Students:");
                foreach (Student item in Students)
                {
                    if (item.Subject == subject)
                    {
                        output.AppendLine($"{item.FirstName} {item.LastName}");
                    }
                }
                return output.ToString().Trim();
            }
        }
        public int GetStudentsCount()
        {
            return Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            return Students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
