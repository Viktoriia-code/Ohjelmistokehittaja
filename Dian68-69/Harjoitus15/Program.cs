using System;

namespace PisinSana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma pyytää käyttäjältä lausetta ja palauttaa lauseen pisimmin sanan.");
            string lause;
            Console.Write("Anna lause: ");
            lause = Console.ReadLine();
            string[] taulu = lause.Split(' ');
            string pisin = taulu[0];
            for (int i = 1; i < taulu.Length; i++)
            {
                if (taulu[i].Length > pisin.Length)
                {
                    pisin = taulu[i];
                }
            }
            Console.WriteLine("Pisin sana on: {0}", pisin);
        }
    }
}