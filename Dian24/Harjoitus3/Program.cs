using System;

namespace Suuruusjarjestys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harjoitus 3. Luvun (0-9) muunto sanaksi.");
            Console.WriteLine("Ohjelma pyytää sinulta lukua ja muuttaa sen sanaksi.");
            Console.Write("Anna kokonaisluku (0-9): ");
            int luku = Convert.ToInt32(Console.ReadLine());
            switch (luku)
            {
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksan");
                    break;
                default:
                    Console.WriteLine("Antamasi arvo ei ole väliltä 1-9");
                    break;
            }
        }
    }
}
