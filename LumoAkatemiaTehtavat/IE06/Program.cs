using System;

namespace PariLuku
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE06. Tee ohjelma, joka tarkastaa, onko annettu luku parillinen vai pariton
        alkusana:
            Console.WriteLine("Tarkastaa, onko annettu luku parillinen vai pariton.");
            Console.Write("Anna luku: ");
            int luku = Convert.ToInt32(Console.ReadLine());
            if (luku % 2 == 0)
            {
                Console.WriteLine($"Luku {luku} on parillinen.");
            }
            else
            {
                Console.WriteLine($"Luku {luku} on pariton.");
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