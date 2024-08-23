using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[100];


            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                vet[i] = random.Next(1, 10);
            }

            Console.WriteLine("Vetor:");


            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i]} ");
            }


            Console.WriteLine();
            Console.WriteLine("Vetor invertido:");



            Inverter(ref vet, 0, vet.Length - 1);


            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i]} ");
            }

            Console.ReadLine();
        }

        static void Inverter(ref int[] vet, int inicio, int fim)
        {
            if (inicio >= fim)
            {

            }

            else
            {
                int temp = vet[inicio];
                vet[inicio] = vet[fim];
                vet[fim] = temp;

                Inverter(ref vet, inicio + 1, fim - 1);
            }
        }
    }
}
