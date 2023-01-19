using System;

namespace Suuruusjarjestys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
            Console.WriteLine("Harjoitus 2. Etsii suurimman kolmesta kokonaisluvusta.");
        spalku:
            try
            {
                Console.Write("Anna 1. kokonaisluku: ");
                luvut[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna 2. kokonaisluku: ");
                luvut[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna 3. kokonaisluku: ");
                luvut[2] = Convert.ToInt32(Console.ReadLine());
                Array.Sort(luvut);
                Console.WriteLine("Suurin luku oli: " + luvut[luvut.Length - 1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja. Try again! :)");
                goto spalku;
            }
        }
    }
}