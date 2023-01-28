using System;

namespace LukuJaollinen5tai11
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE04. Tee ohjelma, joka kysyy käyttäjältä lukua ja tarkistaa, onko se 5:llä tai 11:sta jaollinen
        alkusana:
            Console.WriteLine("Tarkistaa, onko luku 5:llä tai 11:sta jaollinen.");
            Console.Write("Anna luku: ");
            int luku = Convert.ToInt32(Console.ReadLine());
            if (luku % 5 == 0 && luku % 11 == 0)
            {
                Console.WriteLine($"Luku {luku} on 5:llä ja 11:sta jaollinen.");
            }
            else if (luku % 5 == 0)
            {
                Console.WriteLine($"Luku {luku} on 5:llä jaollinen.");
            }
            else if (luku % 11 == 0)
            {
                Console.WriteLine($"Luku {luku} on 11:llä jaollinen.");
            }
            else
            {
                Console.WriteLine($"Luku {luku} ei ole 5:llä tai 11:sta jaollinen.");
            }

            Console.Write("Aloitetaanko alusta (k/e)?");
            string vastaus = Console.ReadLine();
            if (vastaus == "k" || vastaus == "K")
            {
                Console.WriteLine("=====================");
                goto alkusana;
            }
        }
    }
}