using System;

namespace SuurinLukuKolmesta
{
    class Program
    {
        static void Main(string[] args)
        {
            // IE02. Tee ohjelma, joka etsii kolmesta luvusta suurimman
            Console.WriteLine("Löytä kolmesta luvusta suuremman.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            int luku3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================");
            Console.WriteLine($"Annoit luvut: {luku1} {luku2} {luku3}");
            if (luku1 == luku2 && luku2 == luku3)
            {
                Console.WriteLine("Luvut ovat yhtä suuret. Suurempaa numeroa ei löydy.");
            }
            else if (luku1 >= luku2 && luku1 >= 3)
            {
                Console.WriteLine($"Suurin luku on: {luku1}");
            }
            else if (luku2 >= luku1 && luku2 >= luku3)
                {
                Console.WriteLine($"Suurin luku on: {luku2}");
            }
            else if (luku3 >= luku1 && luku3 >= luku2)
            {
                Console.WriteLine($"Suurin luku on: {luku3}");
            }
        }
    }
}