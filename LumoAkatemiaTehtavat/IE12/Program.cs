using System;

namespace IsoPeiniKirjain
{
    class Program
    {
        static void Main(string[] args)
        {
        /* IE12. Tee ohjelma, joka pyytää viiden kokeen pisteitä (Ma, KeFy, Äi, Ru, En -> 0 - 100) ja antaa arvion seuraavasti: 
            Yli 90 pistettä = K5, 
            yli 80 pistettä = H4, 
            yli 70 pistettä = H3, 
            yli 60 pistettä = T2, 
            yli 50 pistettä = T1, 
            muutoin hylätty */
        alkusana:
            Console.WriteLine("Antaa arvion kokeen pisteiden mukana.");
            int[] pisteet = new int[5];
            Console.Write("Anna kokeen pisteet (Ma): ");
            pisteet[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna kokeen pisteet (KeFy): ");
            pisteet[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna kokeen pisteet (Äi): ");
            pisteet[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna kokeen pisteet (Ru): ");
            pisteet[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna kokeen pisteet (En): ");
            pisteet[4] = Convert.ToInt32(Console.ReadLine());
            string[] arviot = new string[5];

            for (int i = 0; i < pisteet.Length; i++)
            {
                if (pisteet[i] >= 90)
                {
                    arviot[i] = "K5";
                } 
                else if (pisteet[i] >= 80)
                {
                    arviot[i] = "H4";
                }
                else if (pisteet[i] >= 70)
                {
                    arviot[i] = "H3";
                }
                else if (pisteet[i] >= 60)
                {
                    arviot[i] = "T2";
                }
                else if (pisteet[i] >= 50)
                {
                    arviot[i] = "T1";
                } else
                {
                    arviot[i] = "hylätty";
                }
            }

            Console.WriteLine($"\n--> Arviot: Ma - {arviot[0]}, KeFy - {arviot[1]}, Äi - {arviot[2]}, Ru - {arviot[3]}, En - {arviot[4]}\n");

            Console.Write("Aloitetaanko alusta (k/e)?");
            string vastaus = Console.ReadLine();
            if (vastaus == "k" || vastaus == "K")
            {
                Console.WriteLine("=====================");
                goto alkusana;
            }
        }
    }
}