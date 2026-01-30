using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflection.InvokePrivateMethod
{
    public class Calculator
    {
        private int Multiply(int a, int b)
        {
            return a*b;
        }
    }
}