using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePath
{
    class Lattice
    {
        public int Width;
        public int Counter = 0;
        public Lattice(int w)
        {
            Width = w;
        }
        public void Travers(int x, int y)
        {
            if (x < Width && y == Width)
                Travers(x + 1, y);

            if (y < Width && x == Width)
                Travers(x, y + 1);

            if (x < Width && y < Width)
            {
                Travers(x + 1, y);
                Travers(x, y + 1);

                Travers(x, y + 1);
                Travers(x + 1, y);
            }

            if (x == Width && y == Width)
                Counter++;
        }
    }
}
