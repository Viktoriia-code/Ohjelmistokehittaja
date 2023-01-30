using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S14. Muuta edellistä tehtävää siten, että lasket parittomien lukujen summan */
            Console.WriteLine("Laskee parittomien lukujen summan 10 ensimmäistä Fibonaccin numeroista.");
            int a = 0, b = 1, c = 0;
            Console.Write($"{a} {b}");
            int paritonSumma = b;
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
                if (c%2 != 0)
                {
                    paritonSumma += c;
                }
            }
            Console.WriteLine($"\nParittomien lukujen summa on: {paritonSumma}");
        }
    }
}