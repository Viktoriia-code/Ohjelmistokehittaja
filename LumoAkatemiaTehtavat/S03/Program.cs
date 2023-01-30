using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S03. Tee ohjelma, joka etsii luvun 3 ensimmäisen esiintymän taulukosta 
               [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3] */
            Console.WriteLine("Etsiä luvun 3 ensimmäisen esiintymän taulukosta [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3].");
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            int luku = 3;
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (luku == taulukko[i])
                {
                    Console.WriteLine($"Ensimmäinen esiintymä luvulle {luku} on kohdassa {i}.");
                    break;
                }
            }
        }
    }
}