using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.GenerateJSON
{
    /*
    Generate a JSON Representation: Write a program that converts an object to a
JSON-like string using Reflection by inspecting its fields and values.
    */
    public class JsonGenerator
    {
        public static void Execute()
        {
            Student student = new Student
            {
                Name = "Prashant",
                Age = 21,
                Marks = 54
            };
            string ans = ToJSON(student);
            Console.WriteLine(ans);
        }
        // method to convert an object to json
        public static string ToJSON(object obj)
        {
            Type type = obj.GetType();
            FieldInfo[] fieldInfos = type.GetFields();
            StringBuilder sb = new StringBuilder("{");
            foreach (FieldInfo field in fieldInfos)
            {
                object? value = field.GetValue(obj);
                sb.Append($"\"{field.Name}\": \"{value}\", ");
            }
            if (sb.Length > 1)
            {
                sb.Length -= 2;
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}