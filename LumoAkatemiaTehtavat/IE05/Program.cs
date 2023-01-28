using System;
using System.Reflection.Metadata;

namespace Karkausvuosi
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE05. Tee ohjelma, joka tarkastaa, onko annettu luku karkausvuosi vai ei
        alkusana:
            Console.WriteLine("Tarkastaa, onko annettu luku karkausvuosi vai ei.");
            Console.Write("Anna vuosi: ");
            int vuosi = Convert.ToInt32(Console.ReadLine());
            if (vuosi % 4 == 0 && vuosi % 100 != 0)
            {
                Console.WriteLine($"Vuosi {vuosi} on karkausvuosi");
            }
            else if (vuosi % 400 == 0)
            {
                Console.WriteLine($"Vuosi {vuosi} on karkausvuosi");
            }
            else
            {
                Console.WriteLine($"Vuosi {vuosi} ei ole karkausvuosi");
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