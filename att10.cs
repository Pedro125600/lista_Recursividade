namespace att10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De um numero inteiro para converter para binario: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Binario(N)}");
        }

        static string Binario(int n)
        {
            if(n == 1 || n == 0)
            {
                return n.ToString();
            }

            else
            {
                return Binario(n / 2) + (n % 2).ToString(); 
            }


        }
    }
}
