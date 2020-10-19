using System;

namespace Asterico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asterisco");

            for(int linha = 0; linha < 10; linha++)
            {
                for (int Coluna = 0; Coluna <= linha; Coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
          
        }
    }
}
