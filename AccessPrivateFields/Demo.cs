using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.AccessPrivateFields
{
    public class Demo
    {
        // Access Private Field: Create a class Person with a private field age. Use Reflection to modify and retrieve its value.
        public static void Execute()
        {
            Person p = new Person();
            Type type = p.GetType();
            // accessing private fields
            FieldInfo? field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Old Value: " + field?.GetValue(p));
            field?.SetValue(p,23);
            Console.WriteLine("New Value: " + field?.GetValue(p));
        }
    }
}