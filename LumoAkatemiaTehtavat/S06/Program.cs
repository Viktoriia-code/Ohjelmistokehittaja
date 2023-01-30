using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // S06. Tee ohjelma, joka laskee keskiarvon taulukosta [6, 7, 2, 4, 3, 8, 1] ilman Math-luokan metodia
            Console.WriteLine("Etsiä maksimiarvon taulukosta [6, 7, 2, 4, 3, 8, 1].");
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1 };
            int summa = 0;
            float keskiarvo;
            for (int i = 0; i < taulukko.Length; i++)
            {
                summa += taulukko[i];
            }
            keskiarvo = (float)summa / taulukko.Length;
            Console.Write("Taulukon [ ");
            foreach (int arvo in taulukko)
            {
                Console.Write($"{arvo} ");
            }
            Console.WriteLine($"] keskiarvo on {keskiarvo}.");
        }
    }
}