using System;
using System.Reflection;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(User);
            MemberInfo [] members =  type.GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine($" {member.MemberType} {member.Name}");
            }
        }
    }
    delegate void CustomDelegate();
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public event CustomDelegate CustomEvent;
        void Invoke()
        {
            CustomEvent?.Invoke();
        }
    }
}

