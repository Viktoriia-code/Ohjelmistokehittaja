using System;

namespace SuurinLuku
{
    class Program
    {
        static void Main(string[] args)
        {
            // P16. Tee ohjelma, joka etsii kolmesta luvusta suurimman
            Console.WriteLine("Löytä suurimman luvun kolmesta luvusta.");
            int[] luvut = new int[3];
            Console.Write("Anna ensimmäinen luku: ");
            luvut[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            luvut[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            luvut[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================");
            Console.WriteLine($"Annoit luvut: {luvut[0]}, {luvut[1]}, {luvut[2]}");
            Array.Sort(luvut);
            Console.WriteLine($"Suurin luku on: {luvut[luvut.Length - 1]}");
        }
    }
}