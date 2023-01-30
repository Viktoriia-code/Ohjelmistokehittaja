using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S09. Tee ohjelma, toiseksi suurimman luvun taulukosta 
               [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3] */
            Console.WriteLine("Etsiä toiseksi suurimman luvun taulukosta [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3].");
            Console.WriteLine("************");
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            Array.Sort(taulukko);
            Console.WriteLine($"Esimäiseksi suurin arvo on {taulukko[taulukko.Length - 1]}.");
            Console.WriteLine($"* Toiseksi suurin arvo on {taulukko[taulukko.Length - 2]}.");
        }
    }
}