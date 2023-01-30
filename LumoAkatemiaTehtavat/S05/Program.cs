using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        // S05. Tee ohjelma, joka etsii maksimiarvon taulukosta [6, 7, 2, 4, 3, 8, 1]
            Console.WriteLine("Etsiä maksimiarvon taulukosta [6, 7, 2, 4, 3, 8, 1].");
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1 };
            int maksimi = 0;
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] > maksimi)
                {
                    maksimi = taulukko[i];
                }
            }
            Console.Write("Taulukon [ ");
            foreach (int arvo in taulukko)
            {
                Console.Write($"{arvo} ");
            }
            Console.WriteLine($"] maksimiarvo on {maksimi}.");
        }
    }
}