using System;

namespace LaskuSumma
{
    class Summa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laskee kaksi lukua yhteen.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int summa = luku1 + luku2;
            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, summa);
        }
    }
}
