using System;
using System.Reflection;

namespace LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom("OtherAssembly");

                Type type = asm.GetType($"{asm.GetName().Name}.Program", true,true);
                object obj = Activator.CreateInstance(type);

                MethodInfo methodInfo = type.GetMethod("GetResult");
                object[] parameters = {1,100,20 };
                object result = methodInfo.Invoke(obj,parameters);
                Console.WriteLine(result);

             }
            catch (Exception)
            {
                Console.WriteLine("Something bad happend...");
            }
        }
    }
}
