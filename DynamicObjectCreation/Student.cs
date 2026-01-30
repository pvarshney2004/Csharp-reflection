using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflection.DynamicObjectCreation
{
    public class Student
    {
        public int RollNo;
        public string? Name;
        public int Marks;
        public Student(int roll, string name, int marks)
        {
            RollNo = roll;
            Name = name;
            Marks = marks;
        }
        public void Display()
        {
            Console.WriteLine("Student details");
            Console.WriteLine($"RollNo: {RollNo} | Name: {Name} | Marks: {Marks}");
        }
    }
}