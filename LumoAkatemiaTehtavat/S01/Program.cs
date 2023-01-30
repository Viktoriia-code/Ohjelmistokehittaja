using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        // S01. Tee ohjelma, laskee, paljonko joudut maksamaan takaisin, kun lainasit 5000€ kahdeksi vuodeksi 2% korolla
            Console.WriteLine("Laskee lainasumman.");
            int laina = 5000;
            int lainaAika = 2;
            double korko = 0.02;
            double korkosumma = 0;
            double maksettava = 0;
            maksettava = laina;
            for (int i = 0; i < lainaAika; i++)
            {
                maksettava += maksettava * korko;
            }
            korkosumma = maksettava - laina;
            maksettava = laina + korkosumma;
            Console.WriteLine($"Maksettavaa tulee {laina} + {korkosumma} = {maksettava}");
        }
    }
}