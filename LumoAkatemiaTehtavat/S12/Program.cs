using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S12. Tee ohjelma, joka tarkastaa, onko annettu sana / lause palidromi (esim. aaroporaa),
               eli luettavissa molemmin päin */
            alkusana:
            Console.WriteLine("Tarkastaa, onko sana palidromi.");
            Console.Write("Anna tarkastettava sana / lause: ");
            string tarkasta = Console.ReadLine();
            char[] kaannettava = tarkasta.ToCharArray();
            Array.Reverse(kaannettava);
            string kaannetty = new string(kaannettava);
            Console.WriteLine(kaannetty);
            if (tarkasta == kaannetty)
            {
                Console.WriteLine("Sana / lause on palidromi.");
            }
            else
            {
                Console.WriteLine("Sana / lause ei ole palidromi.");
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