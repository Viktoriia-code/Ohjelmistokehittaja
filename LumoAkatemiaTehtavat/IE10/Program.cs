using System;

namespace IsoPeiniKirjain
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE10. Tee ohjelma, joka tarkastaa, onko annettu kirjain iso vai pieni
        alkusana:
            Console.WriteLine("Tarkistaa, onko annettu kirjain iso vai pieni.");
            Console.Write("Anna kirjain: ");
            string kirjain = Console.ReadLine();

            for (int i = 0; i < kirjain.Length; i++) 
            {
                if (kirjain[i] == kirjain.ToUpper()[i]) 
                { 
                    Console.WriteLine($"Kirjain {kirjain[i]} on iso kirjain."); 
                }
                else
                {
                    Console.WriteLine($"Kirjain {kirjain[i]} on pieni kirjain.");
                }
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