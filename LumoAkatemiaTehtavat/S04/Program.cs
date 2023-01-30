using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        // S04. Tee ohjelma, kääntää käyttäjän antaman sanan toisinpäin (Hevonen --> nenoveH)
        alkusana:
            Console.WriteLine("Kääntää käyttäjän antaman sanan toisinpäin (Hevonen --> nenoveH).");
            Console.Write("Anna sana: ");
            string sana = Console.ReadLine();
            string anas = "";
            for (int i = sana.Length; i > 0; i--)
            {
                anas += sana[i - 1];
            }
            Console.WriteLine($"Sana '{sana}' toisinpäin on '{anas}'.");


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