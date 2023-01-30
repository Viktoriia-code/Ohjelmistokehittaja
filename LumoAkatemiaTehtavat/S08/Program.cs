using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S08. Tee ohjelma, joka etsii seitsemännen parittoman esiintymän taulukosta
               [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3] */
            Console.WriteLine("Etsiä seitsemännen parittoman esiintymän taulukosta [6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3].");
            Console.WriteLine("************");
            int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            Console.Write("Taulukon parittomat luvut ovat: [ ");
            foreach (int arvo in taulukko)
            {
                if (arvo%2 != 0)
                {
                    Console.Write("{0} ", arvo);
                }
            }
            Console.WriteLine("].");
            int laskuri = 0;
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] % 2 == 0)
                {

                }
                else
                {
                    laskuri++;

                    if (laskuri == 7)
                    {
                        Console.WriteLine("Taulukon 7. pariton luku on: {0} ", taulukko[i]);
                    }
                }
            }
        }
    }
}