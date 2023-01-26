using System;

namespace KilometritMaileiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // P09. Tee ohjelma, joka muuntaa kilometrit maileiksi
            Console.WriteLine("Muuntaa kilometrit maileiksi.");
            Console.Write("Anna kilometrien määrä: ");
            int km = Convert.ToInt32(Console.ReadLine());
            float maili = (float)(km / 1.609);
            Console.WriteLine($"{km} kilometriä on {maili} mailia.");
        }
    }
}