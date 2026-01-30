using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflection.ModifyStaticFields
{
    public class Configuration
    {
        private static string API_KEY = "OLD_VALUE";
        public static void Display()
        {
            Console.WriteLine($"API_KEY: {API_KEY}");
        }
    }
}