using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S10. Tee ohjelma, joka tulostaa sadasta luvusta kolme, kun luku on 3:lla jaollinen, 5, 
               kun luku on 5:llä jaollinen ja 15, kun luku on sekä kolmella, että viidellä jaollinen */
            Console.WriteLine("Tulostaa sadasta luvusta kolme, kun luku on 3:lla jaollinen, 5, kun luku on 5:llä jaollinen ja 15, kun luku on sekä kolmella, että viidellä jaollinen.");
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("viisitoista ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("kolme ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("viisi ");
                }
            }
        }
    }
}