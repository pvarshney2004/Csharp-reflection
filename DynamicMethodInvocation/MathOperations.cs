using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflection.DynamicMethodInvocation
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Substract(int a, int b)
        {
            return a-b;
        }
        public int Multiply(int a, int b)
        {
            return a*b;
        }
    }
}