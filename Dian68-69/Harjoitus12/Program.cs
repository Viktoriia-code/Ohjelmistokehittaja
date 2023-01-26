using System;

namespace LuvunToisto
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            ltalku:
            try
            {
                Console.WriteLine("Ole hyvä ja anna 10:ntä suurempi luku: ");
                luku = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                goto ltalku;
            }
            for (int i = 0; i < luku; i++)
            {
                for (int j = 0; j < luku; j++)
                {
                    Console.Write(luku + " ");
                }
                Console.WriteLine();
                for (int k = 0; k < luku; k++)
                {
                    Console.Write(luku);
                }
                Console.WriteLine();
            }
        }
    }
}