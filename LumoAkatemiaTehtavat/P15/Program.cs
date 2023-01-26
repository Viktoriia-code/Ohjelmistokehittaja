using System;

namespace LaskuTehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            // P15. Kirjoita laskutehtävät (2-5) uudestaan siten, että käyttäjä voi antaa molemmat arvot (a, b)
            Console.WriteLine("Laskee kahden luvun summan, erotuksen, tulon ja osamäärän.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int summa = luku1 + luku2;
            int erotus = luku2 - luku1;
            int tulo = luku1 * luku2;
            float osam = (float)luku2 / luku1;
            Console.WriteLine("=====================");
            Console.WriteLine($"Summa: {luku1} + {luku2} = {summa}");
            Console.WriteLine($"Erotus: {luku2} - {luku1} = {erotus}");
            Console.WriteLine($"Tulo: {luku1} * {luku2} = {tulo}");
            Console.WriteLine($"Osamäärä: {luku2} / {luku1} = {osam}");
        }
    }
}