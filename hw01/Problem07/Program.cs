using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи часа:");
            int chas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Колко пари имаш в теб?");
            decimal money = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Болен ли си?");
            bool isSick = bool.Parse(Console.ReadLine());

            if(isSick == true) // когато си болен
            {
                Console.WriteLine("Няма да излизам!");
            }
            if (isSick == true && money > 0 )
            {
                Console.WriteLine("Ще си купя лекарства!");
            }
            if (isSick == true && money == 0)
            {
                Console.WriteLine("Ще си седя в къщи и ще пия чай!");
            }


            if (isSick == false && money == 0)  // За здрав
            {
                Console.WriteLine("Нямам пари , ще си седя в къщи!");
            }
            if (isSick == false && money > 0 && money < 10M )
            {
                Console.WriteLine("Ще ходя на кафе!");
            }
            if (isSick == false && money > 10M && chas < 10)
            {
                Console.WriteLine("Ще ходя на кино!");
            }
            if (isSick == false && money > 10 && chas > 10)
            {
                Console.WriteLine("Ще ходя на бар!");
            }
            }
        }
    }

