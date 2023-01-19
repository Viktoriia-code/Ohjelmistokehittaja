using System;

namespace Suuruusjarjestys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
            Console.WriteLine("Harjoitus 4. Etsii suurimman viidestä kokonaisluvusta.");
            spalku:
            try
            {
                Console.Write("Anna 1. kokonaisluku: ");
                luvut[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna 2. kokonaisluku: ");
                luvut[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna 3. kokonaisluku: ");
                luvut[2] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna 4. kokonaisluku: ");
                luvut[3] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna 5. kokonaisluku: ");
                luvut[4] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n"+ex.Message);
                Console.WriteLine("Antamasi luvut eivät olleet kokonaislukuja. Try again! :)");
                goto spalku;
            }
            Console.WriteLine("\nAnnoit seuraavat luvut: {0} {1} {2} {3} {4}", luvut[0], luvut[1], luvut[2], luvut[3], luvut[4]);
            Array.Sort(luvut);
            Console.WriteLine("Suurin luku oli: " + luvut[luvut.Length - 1]);
        }
    }
}