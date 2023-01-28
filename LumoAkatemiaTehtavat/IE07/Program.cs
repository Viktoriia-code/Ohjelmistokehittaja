using System;

namespace OnkoKirjain
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE07. Tee ohjelma, joka tarkistaa, onko annettu merkki kirjain vai ei
        alkusana:
            Console.WriteLine("Tarkistaa, onko annettu merkki kirjain vai ei.");
            Console.Write("Anna merkki: ");
            string merkki = Console.ReadLine();
            char[] myChar = merkki.ToCharArray();
            for (int i = 0;i < myChar.Length; i++)
            {
                if (Char.IsLetter(myChar[i]))
                {
                    Console.WriteLine($"Merkki {myChar[i]} on kirjain.");
                }
                else
                {
                    Console.WriteLine($"Merkki {myChar[i]} ei ole kirjain.");
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