using System;

namespace jaarditMetreiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // P12. Tee ohjelma, joka muuntaa yardit metreiksi
            Console.WriteLine("Muuntaa yardit metreiksi.");
            Console.Write("Anna yardien määrä: ");
            int jaardit = Convert.ToInt32(Console.ReadLine());
            float metrit = (float)(jaardit * 0.9144);
            Console.WriteLine($"{jaardit} jaardia on {metrit} metriä.");
        }
    }
}