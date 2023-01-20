using System;

namespace Jakojaannos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjoita ohjelma, joka palauttaa jakojäännöksen. Esim. jakoj(5,2) 🡪 1
            Console.WriteLine("Har. 4. Palauttaa jakojäännöksen.");
            int luku1 = 5;
            int luku2 = 2;
            float jako = (float)luku1 % luku2;
            Console.WriteLine("Numerot ovat: {0} ja {1}.", luku1, luku2);
            Console.WriteLine("Jakojäännöksen on: {0}", jako);
        }
    }
}