using System;

namespace Suuruusjarjestys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
            Console.WriteLine("Harjoitus 2. Etsii suurimman kolmesta kokonaisluvusta.");
            Console.Write("Anna 1. kokonaisluku: ");
            luvut[0] = Int32.Parse(Console.ReadLine());
            Console.Write("Anna 2. kokonaisluku: ");
            luvut[1] = Int32.Parse(Console.ReadLine());
            Console.Write("Anna 3. kokonaisluku: ");
            luvut[2] = Int32.Parse(Console.ReadLine());
            Array.Sort(luvut);
            Console.WriteLine("Suurin luku oli: " + luvut[luvut.Length - 1]);
        }
    }
}