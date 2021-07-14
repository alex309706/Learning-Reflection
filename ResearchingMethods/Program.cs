using System;
using System.Reflection;

namespace ResearchingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Type userType = typeof(User);
            printConstructorInfo(userType);
            printMethodInfo(userType);
            printProperties(userType);
            printFields(userType);
            printImplementedInterfaces(userType);
            Console.WriteLine(userType.Assembly.FullName);





        }
        static void printMethodInfo(Type type)
        {
            Console.WriteLine("Methods:");
            MethodInfo[] MethodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.NonPublic);
            foreach (var methodInfo in MethodInfos)
            {
                string modificator = string.Empty;
                if (methodInfo.IsStatic)
                {
                    modificator += "static ";
                }
                if (methodInfo.IsVirtual)
                {
                    modificator += "virtual ";
                }
                if (methodInfo.IsPrivate)
                {
                    modificator += "private ";
                }

                Console.Write($"{modificator}{methodInfo.ReturnType.Name} {methodInfo.Name} (");
                ParameterInfo[] parameters = methodInfo.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length)
                        Console.Write(",");
                }
                Console.WriteLine(")");
            }
        }
        static void printConstructorInfo(Type type)
        {
            Console.WriteLine("Constructors:");
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach (var constructor in constructorInfos)
            {
                string modificator = string.Empty;
                if (constructor.IsStatic)
                {
                    modificator += "static ";
                }
                if (constructor.IsVirtual)
                {
                    modificator += "virtual ";
                }
                if (constructor.IsPrivate)
                {
                    modificator += "private ";
                }

                Console.Write($"{modificator}{constructor.Name} (");
                ParameterInfo[] parameters = constructor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length)
                        Console.Write(",");
                }
                Console.WriteLine(")");
            }
        }
        static void printProperties(Type type)
        {
            Console.WriteLine("Properties: ");
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var property in propertyInfos)
            {
                Console.WriteLine($"{property.PropertyType} {property.Name}");
            }
        }
        static void printFields(Type type)
        {
            Console.WriteLine("Fields: ");
            FieldInfo[] fieldInfos = type.GetFields();
            foreach (var field in fieldInfos)
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }
        }
        static void printImplementedInterfaces(Type type)
        {
            Console.WriteLine("Implemented Interfaces: ");
            Type [] interfaceInfos = type.GetInterfaces();
            foreach (var implementedInterface in interfaceInfos)
            {
                Console.WriteLine($"{implementedInterface.Name}");
            }
        }
    }
}
