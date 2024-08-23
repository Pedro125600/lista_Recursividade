using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("VAlor de x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("VAlor de y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"O MDC de {x} e {y} = {MDC(x, y)} ");
            Console.ReadLine();
        }


        static int MDC(int x, int y)
        {
            if (y < x)
            {
                if (y == 0)
                {
                    return x;
                }

                else
                {
                    return MDC(y, x % 2);
                }
            }

            else
            {

                if (x == 0)
                {
                    return y;
                }

                else
                {
                    return MDC(x, y % 2);
                }
            }
        }
    }
}
