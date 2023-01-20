using System;

namespace Yhteenlasku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laskee kaksi numeroa yhteen.");
            int luku1 = 3;
            int luku2 = 5;
            int summa = luku1 + luku2;
            Console.WriteLine("Ensimmäinen numero on: " + luku1);
            Console.WriteLine("Toinen numero on: " +luku2);
            Console.WriteLine("Summa on: {0} + {1} = {2}", luku1, luku2, summa);
        }
    }
}