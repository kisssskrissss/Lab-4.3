using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа А,В и С");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            int kol = 0;
            while (A >= C) 
            { 
                A = A - C;
                a++;
            }
            while (B >= C) 
            {
               B = B - C;
                b++;
            }
            while (a > 0) 
            {
                kol = kol + b;
                a = a - 1;
            }
            Console.WriteLine("{0} квадратов ", kol);
            Console.ReadKey();



        }
    }
}
