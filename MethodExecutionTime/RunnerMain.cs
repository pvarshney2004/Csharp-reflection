using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection.MethodExecutionTime
{
    public class RunnerMain
    {
        public static void Execute()
        {
            Type type = typeof(Demo);
            foreach (MethodInfo method in type.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(new Demo(), null);
                sw.Stop();
                Console.WriteLine($"{method.Name} took {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}