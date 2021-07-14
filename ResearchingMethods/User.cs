using System;
namespace ResearchingMethods
{
    delegate void CustomDelegate();
    class User:IPrintable
    {
        public string Name { get; set; }
        public int Age;
        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value >= 1)
                    Age = value;
                else if (value > 150)
                    Console.WriteLine($"Nobody trust tou! People don't live that much.");

                else
                {
                    Console.WriteLine($"The {value} is less than 1. the Age can not be negative.");
                }

            }
        }
        public event CustomDelegate CustomEvent;
        void Invoke()
        {
            CustomEvent?.Invoke();
        }

        public virtual void PressKeyboard(char key)
        {
            Console.WriteLine($"The user pressed {key} ");
        }
        public void Print()
        {
            Console.WriteLine($"The name of the user is {Name} . The user is {Age} years old");
        }
        public int GetRandomInt(int upperBound, int lowerBound)
        {
            return new Random().Next(upperBound, lowerBound);
        }
        public User(int inputAge)
        {
            age = inputAge;
        }
        public User(string inputName)
        {
            Name = inputName;
        }
    }
    interface IPrintable
    {
        void Print();
    }
}
