using System;

namespace Suuruusjarjestys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harjoitus 1. Lukujen suuruusjärjestäminen.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            if (luku2 > luku1)
            {
                Console.WriteLine("Lukujen järjestys {0}, {1}", luku1, luku2);
            }
            else
            {
                Console.WriteLine("Lukujen järjestys {0}, {1}", luku2, luku1);
            }
        }
    }
}