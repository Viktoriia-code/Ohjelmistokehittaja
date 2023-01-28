using System;

namespace SuurinLukuKahdesta
{
    class Program
    {
        static void Main(string[] args)
        {
            // IE01. Tee ohjelma, joka etsii kahdesta luvusta suuremman
            Console.WriteLine("Löytä kahdesta luvusta suuremman.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================");
            Console.WriteLine($"Annoit luvut: {luku1} ja {luku2}");
            if (luku1 == luku2)
            {
                Console.WriteLine("Luvut ovat yhtä suuret. Suurempaa numeroa ei löydy.");
            } else if (luku1 > luku2)
            {
                Console.WriteLine($"Suurin luku on: {luku1}");
            } else
            {
                Console.WriteLine($"Suurin luku on: {luku2}");
            }
        }
    }
}