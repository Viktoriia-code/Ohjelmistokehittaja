using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // S02. Tee ohjelma, joka laskee annetun luvun kertoman
            Console.WriteLine("Laskee annetun luvun kertoman.");
            int luku = 1;
            int kertoma = 1;
            Console.Write("Anna luku, josta lasketaan kertoma: ");
            luku = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= luku; i++)
            {
                kertoma *= i;
            }
            Console.WriteLine($"Luvun {luku} kertoma on {kertoma}.");
        }
    }
}