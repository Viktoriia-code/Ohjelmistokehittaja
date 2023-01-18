using System;

namespace LaskuOsamaara
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erotus
            Console.WriteLine("Laskee kahden luvun osamäärän.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            float osamaara = (float)luku1/luku2;
            Console.WriteLine("{0} / {1} = {2}", luku1, luku2, osamaara);
        }
    }
}