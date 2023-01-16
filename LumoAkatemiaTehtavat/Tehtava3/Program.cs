using System;

namespace LaskuErotus
{
    class Erotus
    {
        static void Main(string[] args)
        {
            // Erotus
            Console.WriteLine("Laskee kahden luvun erotuksen.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int erotus = luku1 - luku2;
            Console.WriteLine("{0} - {1} = {2}", luku1, luku2, erotus);
        }
    }
}