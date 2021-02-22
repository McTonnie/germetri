using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germetri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square kvadrat = new Square(10);
            Square kvadrat2 = new Square(17);
            Square kvadrat3 = new Square(27);
            Square kvadrat4 = new Square(239);
            Console.WriteLine(kvadrat.omkreds());
            Console.WriteLine(kvadrat2.omkreds());
            Console.WriteLine(kvadrat3.omkreds());
            Console.WriteLine(kvadrat4.omkreds());


            kvadrat.setside(100);
            Console.WriteLine(kvadrat.omkreds());
            Console.ReadKey();
        }
    }
}
