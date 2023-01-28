using System;

namespace IsoPeiniKirjain
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE11. Tee ohjelma, joka laskee annetuista myynti ja ostoluvuista, saitko voittoa vai tappiota
        alkusana:
            Console.WriteLine("Laskee annetuista myynti ja ostoluvuista, saitko voittoa vai tappiota.");
            Console.Write("Anna myynti eurolla: ");
            int myynti = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna ostoluvut eurolla: ");
            int ostoluvut = Convert.ToInt32(Console.ReadLine());
            int tulos = myynti - ostoluvut;

            if (tulos > 0)
            {
                Console.WriteLine($"Sait voittoa: {tulos} euroa.");
            } 
            else if (tulos < 0)
            {
                Console.WriteLine($"Sait tappiota: {tulos} euroa.");
            } 
            else
            {
                Console.WriteLine("Et saanut mitään.");
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