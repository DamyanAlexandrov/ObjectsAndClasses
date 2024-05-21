using System.Numerics;

namespace ex3_lab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}
