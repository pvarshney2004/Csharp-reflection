using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.DynamicObjectCreation
{
    public class CreateObj
    {
        // Dynamically Create Objects: Write a program to create an instance of a Student class dynamically using Reflection without using the new keyword. 
        public static void Execute()
        {
            Type type = typeof(Student);
            ConstructorInfo? constructor = type.GetConstructor(new Type[]{ typeof(int),typeof(string),typeof(int) });
            Student student = (Student)constructor.Invoke([4,"Emma",56 ]);
            student.Display();
        }
    }
}