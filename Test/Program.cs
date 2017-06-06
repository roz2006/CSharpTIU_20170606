using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Adler = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Adler = 5, Navn = "Lady" };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            using (StreamReader stream = System.IO.File.OpenText(@"C:\temp\names.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string nanv = stream.ReadLine();
                    Console.WriteLine(nanv);
                }
            }
        }
    }

    class Hund:IComparable
    {
        public string Navn { get; set; }
        public int Adler { get; set; }

        public int CompareTo(object obj)
        {
            Hund h1 = obj as Hund;
           
            if (Adler > h1.Adler)
                return -2;
            else
                return -1;
        }
    }
}
