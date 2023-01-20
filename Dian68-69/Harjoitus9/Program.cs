using System;

namespace Jakojaannos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjoita tehtävä 4 uudelleen siten, että käyttäjä voi antaa ko. numerot
            Console.WriteLine("Palauttaa jakojäännöksen.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            float jako = (float)luku1 % luku2;
            Console.WriteLine("Annoit numerot: {0} ja {1}.", luku1, luku2);
            Console.WriteLine("Jakojäännöksen on: {0}", jako);
        }
    }
}