using System;

namespace ParittomatLuvut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tulostaa parittomat luvut väliltä 1-99.");
            for (int i = 1; i <= 99; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}