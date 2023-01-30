using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S11. Tee ohjelma, joka tulostaa 10 ensimmäistä Fibonaccin numeroa (0, 1, 1, 2, 3, 5...), 
               eli seuraava luku on kahden edellisen summa */
            Console.WriteLine("Tulostaa 10 ensimmäistä Fibonaccin numeroa.");
            int a = 0, b = 1, c = 0;
            Console.Write($"{a} {b}");
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }
    }
}