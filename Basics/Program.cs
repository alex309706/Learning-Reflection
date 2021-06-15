using System;
using Domain;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alex = new Student();
            Type typeOfObject = alex.GetType();

            Type gettingTypeByTypeOf = typeof(Student);
            Type gettingTypeByStaticMethod = Type.GetType("Domain.Student,Domain",false,true);

            Console.WriteLine(gettingTypeByTypeOf.ToString());
            Console.WriteLine(typeOfObject.ToString());
            Console.WriteLine(gettingTypeByStaticMethod.ToString());
        }
    }
    
}
