using System;

namespace Bonuspisteet
{
    class Program
    {
        static void Main(string[] args)
        {
            int ibonus;
            bonusalku:
            Console.Write("Anna bonusten määrä: (1-9): ");
            try
            {
                ibonus = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvo ei ollut kokonaisluku.");
                goto bonusalku;
            }
            switch (ibonus)
            {
                case 1:
                case 2:
                case 3:
                    ibonus *= 3;
                    break;
                case 4:
                case 5:
                case 6:
                    ibonus *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    ibonus *= 1000;
                    break;
                default:
                    Console.WriteLine("Antamasi arvo ei ole välillä 1-9.");
                    goto bonusalku;
            }
            Console.WriteLine("Lopullinen bonus on: " + ibonus);
        }
    }
}