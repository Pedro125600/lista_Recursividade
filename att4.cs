using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o valor de N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor de Pell(N) e " + CalcPell(n));
            Console.ReadLine();
            
        }

        static int CalcPell(int n)
        {
            if(n == 0)
            {
                return 0;
            }

            else if(n == 1)
            {
                return 1;
            }

            else
            {
                return 2 * CalcPell(n - 1) + CalcPell(n - 2);
            }
        }
    }
}
