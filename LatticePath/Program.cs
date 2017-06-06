using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePath
{
    class Program
    {
        static void Main(string[] args)
        {
            Lattice myLattice = new Lattice(2);
            myLattice.Travers(1,1);
            Console.WriteLine(myLattice.Counter);
        }
    }
}
