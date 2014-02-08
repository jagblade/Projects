using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("The Sum is: " + (a + b));
            Console.WriteLine("Diference is: " + (a - b));
            Console.WriteLine("Product is: " + (a * b));
            Console.WriteLine("Division is: " + (a / b));
            Console.WriteLine("Residue is: " + (a % b));
        }
    }
}
