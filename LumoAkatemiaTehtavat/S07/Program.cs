using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S07. Tee ohjelma, joka tekee uuden taulukon taulukosta ["a", "b", "c", "d", "e", "f"] 
               siten, että kaikki kirjaimet ovat isoja */
            Console.WriteLine("Tee uuden taulukon taulukosta [\"a\", \"b\", \"c\", \"d\", \"e\", \"f\"] siten, että kaikki kirjaimet ovat isoja.");
            Console.WriteLine("************");
            string[] taulukko = new string[] { "a", "b", "c", "d", "e", "f" };
            Console.Write("Taulukon kirjaimet pienina: [ ");
            foreach (string arvo in taulukko)
            {
                Console.Write("{0} ", arvo);
            }
            Console.WriteLine("]");
            string[] isot = new string[6];
            for (int i = 0; i < taulukko.Length; i++)
            {
                isot[i] = taulukko[i].ToUpper();
            }
            Console.Write("Taulukon kirjaimet isoina: [ ");
            foreach (string arvo in isot)
            {
                Console.Write("{0} ", arvo);
            }
            Console.WriteLine("]");
        }
    }
}