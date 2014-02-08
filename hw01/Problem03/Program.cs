using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            double b = double.Parse(Console.ReadLine());

            double c = b;
                   b = a;
                   a = c;

            Console.WriteLine("Switched A: " + a + " ; Switched B: "+b );

        }
    }
}
