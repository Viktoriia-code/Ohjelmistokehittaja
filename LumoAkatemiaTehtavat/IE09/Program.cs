using System;
using System.Text.RegularExpressions;

namespace KirjainNumeroMerkki
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE09. Tee ohjelma, joka tarkastaa, onko annettu merkki kirjain, numero vai erikoismerkki
        alkusana:
            Console.WriteLine("Tarkistaa, onko annettu merkki kirjain, numero vai erikoismerkki.");
            Console.Write("Anna merkki: ");
            string merkki = Console.ReadLine();
            char[] myChar = merkki.ToCharArray();
            Regex regexNumber = new Regex(@"[0-9]");
            for (int i = 0; i < myChar.Length; i++)
            {
                Match matchNumber = regexNumber.Match(myChar[i].ToString());
                if (Char.IsLetter(myChar[i]))
                {
                    Console.WriteLine($"Merkki {myChar[i]} on kirjain.");
                }
                else if (matchNumber.Success)
                {
                    Console.WriteLine($"Merkki {myChar[i]} on numero.");
                }
                else
                {
                    Console.WriteLine($"Merkki {myChar[i]} on erikoismerkki.");
                }
            };

            Console.Write("Aloitetaanko alusta (k/e)?");
            string vastaus = Console.ReadLine();
            if (vastaus == "k" || vastaus == "K")
            {
                Console.WriteLine("=====================");
                goto alkusana;
            }
        }
    }
}