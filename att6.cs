using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o valor de N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{SuperFatorial(n)} ");
            Console.ReadLine();
        }

        static int SuperFatorial(int N)
        {

            if (N == 1)
            {
                return 1;
            }

            else
            {

                return fatorial(N) * SuperFatorial(N - 1);

            }
        }

        static int fatorial(int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }

            else
            {

                return n * fatorial(n - 1);

            }
        }


    }
}
