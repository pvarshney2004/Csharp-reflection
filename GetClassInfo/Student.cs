using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflection.GetClassInfo
{
    public class Student
    {
        public int RollNo;
        public string? Name;
        public int Marks;
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }
        public Student(int roll, string name, int marks)
        {
            RollNo = roll;
            Name = name;
            Marks = marks;
        }
        public void Display()
        {
            Console.WriteLine("Display details");
        }
    }
}