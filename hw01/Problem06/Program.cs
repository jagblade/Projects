using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a1:");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a2:");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a3:");
            double a3 = double.Parse(Console.ReadLine());

            double s = a1;
            a1 = a2;
            a2 = a3;
            a3 = s;

            Console.WriteLine("a1: " + a1 + " ; a2: " + a2 + " ; a3: " + a3);
        }
    }
}
