using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alex = new Student();
            Type typeOfObject = alex.GetType();

            Type gettingTypeByTypeOf = typeof(Student);
            Type gettingTypeByStaticMethod = Type.GetType("Basics.Student",false,true);

            Console.WriteLine(gettingTypeByTypeOf.ToString());
            Console.WriteLine(typeOfObject.ToString());
            Console.WriteLine(gettingTypeByStaticMethod.ToString());

        }

    }
    class Student 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string GradeBookNumber { get; set; }

    }
}
