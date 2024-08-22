namespace att3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De um numero inteiro positivo impar");
            int N = int.Parse(Console.ReadLine());
            int resultado = FatorialDuplo(N);
            Console.WriteLine($"O fatorial duplo de {N} é: {resultado}");
        }

        static int FatorialDuplo(int N)
        {
            if (N <= 1) 
            {
                return 1;
            }
            else 
            {
                return N * FatorialDuplo(N - 2);
            }
        }
    }
}
