using System;

namespace MailitKilometreiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma, joka muuntaa mailit kilometreiksi
            Console.WriteLine("Muuntaa mailit kilometreiksi.");
            Console.Write("Anna mailien määrä: ");
            int maili = Convert.ToInt32(Console.ReadLine());
            float km = (float)(maili * 1.609);
            Console.WriteLine($"{maili} mailia on {km} kilometriä.");
        }
    }
}