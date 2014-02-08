using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(b + "  " + a);
            }
            else
            {
                Console.WriteLine(a + "  " + b);
            }
        }
    }
}
