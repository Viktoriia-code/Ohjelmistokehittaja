using System;

namespace SanaksiIso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string sana = "";
        alkusana:
            Console.Write("Anna numero (0-999), jonka ohjelma muuntaa sanaksi: ");
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi arvo ei ole kokonaisluku!");
                goto alkusana;
            }
            if (numero > 999 || numero < 0)
            {
                Console.WriteLine("Annoit luvun, joka ei ole välillä 0-999.");
                goto alkusana;
            }
            string[] ones = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmenen" };
            if (numero == 0)
            {
                sana = "zero";
            }
            else if (numero < 11)
            {
                sana = ones[numero];
            }
            else if (numero > 10 && numero < 20)
            {
                sana = ones[numero - 10]+"toista";
            }
            else if (numero > 19 && numero < 100)
            {
                sana = ones[numero / 10] + "kymmentä" + ones[numero % 10];
            }
            else if (numero == 100)
            {
                sana = "sata";
            }
            else if (numero > 99 && numero % 100 == 0) 
            {
                sana = ones[numero / 100] + "sataa";
            }
            else if (numero == 110)
            {
                sana = "satakymmenen";
            }
            else if (numero > 100 && numero < 200)
            {
                sana = "sata" + ones[(numero % 100) / 10] + "kymmentä" + ones[numero%10];
            }
            else if (numero > 200 && numero % 100 == 10) 
            {
                sana = ones[numero/100] + "sataakymmenen";
            }
            else 
            {
                sana = ones[numero / 100] + "sataa" + ones[(numero % 100) / 10] + "kymmentä" + ones[numero % 10];
            }
            Console.WriteLine("Annoit numero: {0}", numero);
            Console.WriteLine("Se kirjoitetaan: {0}", sana);
            Console.Write("Aloitetaanko alusta (k/e)?");
            string vastaus = Console.ReadLine();
            if (vastaus == "k" || vastaus == "K")
            {
                goto alkusana;
            }
        }
    }
}