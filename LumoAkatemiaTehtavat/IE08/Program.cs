using System;
using System.Text.RegularExpressions;

namespace VokaaliKirjain
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE08. Tee ohjelma, joka tarkastaa, onko annettu kirjain vokaali vai konsonantti
        alkusana:
            Console.WriteLine("Tarkastaa, onko annettu kirjain vokaali vai konsonantti.");
            Console.Write("Anna kirjain: ");
            string kirjain = Console.ReadLine();
            char[] myChar = kirjain.ToCharArray();
            Regex regex = new Regex(@"(?i)[aoeiuyäöå]");

            for (int i = 0; i < myChar.Length; i++)
            {
                Match match = regex.Match(myChar[i].ToString());
                if (match.Success)
                {
                    Console.WriteLine($"Kirjain {myChar[i]} on vokaali.");
                }
                else
                {
                    Console.WriteLine($"Kirjain {myChar[i]} on konsonantti.");
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