using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.DynamicMethodInvocation
{
    public class DynamicMain
    {
        /*
        Dynamic Method Invocation: Define a class MathOperations with multiple public
methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method
based on user input.
        */
        public static void Execute()
        {
            Console.Write("Enter method name (Add/Subtract/Multiply): ");
            string? methodName = Console.ReadLine();

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Type type = typeof(MathOperations);
            object? obj = Activator.CreateInstance(type);

            MethodInfo? method = type.GetMethod(methodName);
            if (method == null)
            {
                Console.WriteLine("Method not found");
                return;
            }
            var result = method.Invoke(obj, new object[] { a, b });
            Console.WriteLine($"Result: {result}");
        }
    }
}