using System;

namespace KolmellaJaolliset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tulostaa kolmella jaolliset luvut väliltä 1-99.");
            for (int i = 3; i <= 99; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}