using System;

namespace SentitTuumiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // P11. Tee ohjelma, joka muuntaa sentit tuumiksi
            Console.WriteLine("Muuntaa sentit tuumiksi.");
            Console.Write("Anna senttien määrä: ");
            int sentit = Convert.ToInt32(Console.ReadLine());
            float tuumat = (float)(sentit / 2.54);
            Console.WriteLine($"{sentit} senttiä on {tuumat} tuumaa.");
        }
    }
}