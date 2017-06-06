using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage("Garage one");
            carLot.Print();
            Console.WriteLine(carLot.GetName());
            Car mycar = new Car("a", 1);
            Car myothercar = new Car("b", 1);

            ICommonMethods myinterface = mycar as ICommonMethods;
            myinterface.Print();

            if (carLot is ICommonMethods)
                carLot.Print();

            Console.WriteLine(mycar.CompareTo(myothercar));
            //Car[] cars = new Car[]
            //{new Car("a",1),
            //new Car("b",2),
            //new Car("c",3)
            //};

            //// Hand over each car in the collection?
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine("{0} is going {1} MPH",
            //    c.name, c.age);
            //}
            //Console.ReadLine();


        }
    }
}
