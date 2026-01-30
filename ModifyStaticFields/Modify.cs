using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.ModifyStaticFields
{
    public class Modify
    {
        /*
        Access and Modify Static Fields: Create a Configuration class with a private static
field API_KEY. Use Reflection to modify its value and print it.
        */
        public static void Execute()
        {
            Type type = typeof(Configuration);
            FieldInfo? field = type.GetField("API_KEY", BindingFlags.Static | BindingFlags.NonPublic);
            Configuration.Display();
            field?.SetValue(null, "NEW_SECRET_KEY");
            Configuration.Display();
        }
    }
}