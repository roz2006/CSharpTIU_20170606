using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Garage : MyAbstractClass, ICommonMethods
    {
        private Car[] carArray = new Car[4];
        public string Name;
        // Fill with some Car objects upon startup.
        public Garage(string n)
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
            Name = n;
        }

        public string GetName()
        {
            return Name;
        }

        public void Print()
        {
            Console.WriteLine("The is garage {0}", Name);
        }

        public override void SetFirstName()
        {
            Console.WriteLine("Please enter garage owner's first name:");
            FirstName = Console.ReadLine();
        }

        public override void PrintName()
        {
            Console.WriteLine(FirstName);
        }

        public override string GetLastName()
        {
            return base.GetLastName();
        }
    }

    class Car : ICommonMethods, IComparable
    {
        public string name;
        public int year;

        public Car(string n, int a)
        {
            name = n;
            year = a;
        }

        public int CompareTo(Car obj)
        {
            Car c = obj as Car;
            if (this.name == c.name && this.year == c.year)
                return 1;
            else
                return -1;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return name;
        }

        public void Print()
        {
            Console.WriteLine("this is a car called {0}", name);
        }
        
    }
}
