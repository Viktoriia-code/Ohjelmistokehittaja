using System;
using System.Diagnostics.Metrics;

namespace MetritJaardeiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // P13. Tee ohjelma, joka muuntaa metrit yardeiksi
            Console.WriteLine("Muuntaa metrit yardeiksi.");
            Console.Write("Anna metrien määrä: ");
            int metrit = Convert.ToInt32(Console.ReadLine());
            float jaardit = (float)(metrit / 0.9144);
            Console.WriteLine($"{metrit} metriä on {jaardit} jaardia.");
        }
    }
}