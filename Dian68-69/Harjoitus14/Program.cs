using System;

namespace PosNegLuvut
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            lealku:
            Console.WriteLine("Tämä ohjelma pyytää käyttäjältä kahta lukua ja tarkastaa niiden etumerkit.");
            try
            {
                Console.Write("Ole hyvä ja anna ensimmäinen kokonaisluku: ");
                luku1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ole hyvä ja anna toinen kokonaisluku: ");
                luku2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvot eivät olleet kokonaislukuja. Yritä uudelleen: ");
                goto lealku;
            }
            if (luku1 >= 0 && luku2 >= 0)
            {
                Console.WriteLine("Luvut ovat positiivisia");
            }
            else if (luku1 < 0 && luku2 < 0)
            {
                Console.WriteLine("Luvut ovat negatiivisia");
            }
            else
            {
                Console.WriteLine("Luvuista toinen on positiivinen ja toinen negatiivinen");
            }
        }
    }
}