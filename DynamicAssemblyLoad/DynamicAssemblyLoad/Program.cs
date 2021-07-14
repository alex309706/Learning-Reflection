using System;
using System.Reflection;

namespace DynamicAssemblyLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("DynamicAssemblyLoad");
            Type [] types =  asm.GetTypes();

            Console.WriteLine(asm.FullName);

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
            }

        }
    }
}
