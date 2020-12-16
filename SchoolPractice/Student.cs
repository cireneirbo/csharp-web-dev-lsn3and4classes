using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name { get, set};
        private int StudentId;
        private int NumberOfCredits;
        private double Gpa;

        public Student(string Name, int StudentId, int NumberOfCredits, double Gpa)
        {
            this.Name = Name;
            this.StudentId = StudentId;
            this.NumberOfCredits = NumberOfCredits;
            this.Gpa = Gpa;
        }

    }
}
