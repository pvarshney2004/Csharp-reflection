using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection.GetClassInfo
{
    public class GetClassInfoMain
    {
        /*
        Get Class Information: Write a program to accept a class name as input and display
        its methods, fields, and constructors using Reflection.
        */
        public static void Execute()
        {
            System.Console.WriteLine("Enter class name: ");
            string? className = Console.ReadLine();
            Student s = new Student();
            Type? type = s.GetType();
            if(type == null)
            {
                Console.WriteLine("Type not found");
                return;
            }

            Console.WriteLine($"Class FullName: {type.FullName}");
            Console.WriteLine($"Class Name: {type.Name}");

            // fields
            Console.WriteLine($"Fields in class {type.Name}:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo f in fields)
            {
                Console.WriteLine($"- {f.FieldType.Name} {f.Name}");
            }

            // methods
            Console.WriteLine($"Methods in class {type.Name}:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine($"- {method.ReturnType.Name} {method.Name}");
            }

            // constructors
            Console.WriteLine($"Constructors in class {type.Name}:");
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach(ConstructorInfo cons in constructors)
            {
                Console.WriteLine($"- {cons.Name}");
            }



        }
    }
}