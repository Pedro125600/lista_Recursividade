namespace att2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de i:");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de i:");
            int j = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de i:");
            int k = int.Parse(Console.ReadLine());

            int soma = SomaSerie(i, j, k);
            Console.WriteLine($"A soma da série de {i} até {j} com incremento {k} é: {soma}");

        }

        static int SomaSerie(int i, int j, int k)
        {
            int IJ = 0;
            if (i > j) 
            {
             return   IJ = i + j + SomaSerie(i - 1, j + 1, k);
            }

            else if (j > i)
            {
              return  IJ = i + j+ SomaSerie(i + 1, j - 1, k);
            }
            else 
            {
                return IJ + K;
            }

            
        }

    }
}
