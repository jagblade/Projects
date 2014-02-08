using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
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

            if (a<c && c<b)
            {
                Console.WriteLine(c+" is between "+a+" and "+b);
            }
            else
            {
                Console.WriteLine(c + " is NOT between " + a + " and " + b);
            }
        }
    }
}
