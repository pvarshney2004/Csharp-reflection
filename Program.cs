using System;
using Reflection.AccessPrivateFields;
using Reflection.DynamicMethodInvocation;
using Reflection.DynamicObjectCreation;
using Reflection.GenerateJSON;
using Reflection.GetClassInfo;
using Reflection.InvokePrivateMethod;
using Reflection.MethodExecutionTime;
using Reflection.ModifyStaticFields;
using Reflection.RetrieveAttributeAtRuntime;
namespace Reflection
{
    class Program
    {
        public static void Main(string[] args)
        {
            // GetClassInfoMain.Execute();
            // Demo.Execute();
            // Invoke.Execute();
            // CreateObj.Execute();
            // DynamicMain.Execute();
            // Retrieve.Execute();
            // Modify.Execute();
            // JsonGenerator.Execute();
            RunnerMain.Execute();
        }
    }
}