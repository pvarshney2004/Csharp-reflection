using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.InvokePrivateMethod
{
    public class Invoke
    {
        // Invoke Private Method: Define a class Calculator with a private method Multiply(int a, int b). Use Reflection to invoke this method and display the result.
        public static void Execute()
        {
            Calculator calc = new Calculator();
            Type type = calc.GetType();
            MethodInfo? method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
            int result = (int)method.Invoke(calc, [5, 10]);
            Console.WriteLine("Multiplication Result: " + result);
        }
    }
}