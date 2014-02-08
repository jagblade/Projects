using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter C:");
            double c = double.Parse(Console.ReadLine());

            if (a > b && b > c && a > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            if (a > b && b < c && a > c)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
            if ( b > a && a > c && b > c )
            {
                Console.WriteLine(c + " " + a + " " + b);
            }

            if (b > a && c > a && b > c)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
            if (c > a && a > b && c > b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            if (c > a && b > a && c > b)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}
