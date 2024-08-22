namespace recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De um numero N para se calcular a soma dos primeiros numeros primos");
            int n = int.Parse(Console.ReadLine());
            int soma = SomaCubos(n);
            Console.WriteLine($"A soma dos primeiros {n} cubos é: {soma}");
        }

        static int SomaCubos(int n)
        {
            if (n == 1) 
            {
                return 1;
            }
            else 
            {
                return n * n * n + SomaCubos(n - 1);
            }
        }
    }
}
