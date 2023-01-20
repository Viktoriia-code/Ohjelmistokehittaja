using System;

namespace Perus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjoita ohjelma, joka tekee kaikki 4 peruslaskutoimitusta annetuille luvuille. Esim. perus(8,5) 🡪 13 / 3 / 40 / 1,6
            Console.WriteLine("Tekee kaikki 4 peruslaskutoimitusta annetuille luvuille.");
            int luku1 = 8;
            int luku2 = 5;
            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;
            float osam = (float)luku1 / luku2;
            Console.WriteLine("Numerot ovat: {0} ja {1}", luku1, luku2);
            Console.WriteLine("Tulokset ovat: {0} / {1} / {2} / {3}", summa, erotus, tulo, osam);
        }
    }
}