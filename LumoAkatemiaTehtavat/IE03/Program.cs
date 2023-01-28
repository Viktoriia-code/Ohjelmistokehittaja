using System;

namespace TarkistaLuku
{
    class Program
    {
        static void Main(string[] args)
        {
        // IE03. Tee ohjelma, joka etsii tarkistaa, onko luku negatiivinen, nolla vai positiivinen
            alkusana:
            Console.WriteLine("Tarkistaa, onko luku negatiivinen, nolla vai positiivinen.");
            Console.Write("Anna luku: ");
            int luku = Convert.ToInt32(Console.ReadLine());
            if (luku == 0)
            {
                Console.WriteLine("Luku on nolla.");
            }
            else if (luku > 0)
            {
                Console.WriteLine("Luku on positiivinen.");
            }
            else
            {
                Console.WriteLine("Luku on negatiivinen.");
            }
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