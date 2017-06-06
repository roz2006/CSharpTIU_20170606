using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class MyAbstractClass
    {
        public abstract void SetFirstName();

        public string FirstName;

        public abstract void PrintName();

        public virtual string GetLastName()
        {
            Console.WriteLine("Please enter last name");
            return Console.ReadLine();
        }

        
    }
}
