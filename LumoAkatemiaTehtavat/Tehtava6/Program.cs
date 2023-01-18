using System;

namespace LaskuTulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erotus
            Console.WriteLine("Laskee kahden luvun jakojäännöksen.");
            Console.Write("Anna ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());
            float jako = (float)luku1%luku2;
            Console.WriteLine("Jakojäänös on: {0} % {1} = {2}", luku1, luku2, jako);
        }
    }
}