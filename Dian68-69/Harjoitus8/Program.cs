using System;

namespace Perus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjoita tehtävä 3 uudelleen siten, että käyttäjä voi antaa ko. numerot
            Console.WriteLine("Tekee kaikki 4 peruslaskutoimitusta annetuille luvuille.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;
            float osam = (float)luku1 / luku2;
            Console.WriteLine("Annoit numerot: {0} ja {1}.", luku1, luku2);
            Console.WriteLine("Tulokset ovat: {0} / {1} / {2} / {3}", summa, erotus, tulo, osam);
        }
    }
}