using System;

namespace KirjainVaihto
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana, uusisana;
            int pituus;
            Console.Write("Anna sana, jonka ensimmäinen ja viimeinen kirjain vaihdetaan keskenään: ");
            sana = Console.ReadLine();
            pituus = sana.Length;
            char[] taulu = new char[pituus];
            for (int i = 0; i < pituus; i++)
                taulu[i] = sana[i];
            taulu[0] = sana[pituus - 1];
            taulu[pituus - 1] = sana[0];
            uusisana = String.Join("", taulu);
            Console.WriteLine("Annoit sanan {0} ja se on muutettuja {1}", sana, uusisana);
        }
    }
}