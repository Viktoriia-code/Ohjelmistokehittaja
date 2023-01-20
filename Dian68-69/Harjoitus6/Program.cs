using System;

namespace Yhteenlasku
{
    class Program
    {
        static void Main(string[] args)
        {
            //käyttäjä voi antaa ko. numerot
            Console.WriteLine("Laskee kaksi numeroa yhteen.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int summa = luku1 + luku2;
            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, summa);
        }
    }
}