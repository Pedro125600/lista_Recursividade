using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o valor de N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{valorS(n)} ");
            Console.ReadLine();

        }

        static double valorS(int n)
        {
            if(n ==1)
            {
                return 2;
            }
            else
            {
                return ((1 + Math.Pow(n, 2)) / n) + valorS(n - 1);
            }
        }
    }
}
