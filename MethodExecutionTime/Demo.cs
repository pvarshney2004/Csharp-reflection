using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflection.MethodExecutionTime
{
    // demo class that contains task methods
    public class Demo
    {
        public void TaskA()
        {
            Thread.Sleep(500);
        }
        public void TaskB()
        {
            Thread.Sleep(1200);
        }
    }
}