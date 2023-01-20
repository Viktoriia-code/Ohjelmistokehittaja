using System;

namespace Kertotaulu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjoita ohjelma, joka kysyy käyttäjältä kokonaislukua välillä 1 – 10 ja tulostaa sitten ko.luvun kertotaulun(käytä silmukkaa hyväksesi).
            Console.WriteLine("Har. 10. Tulostaa kertolaukun.");
            spalkku:
            Console.Write("Anna numero (1-10): ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 1 || numero > 10)
            {
                Console.WriteLine("Annoit väärin numeron. Numeron pitää olla 1-10.");
                goto spalkku;
            }
            for(var i=1;i<11;i++)
            {
                Console.WriteLine(numero+" x "+i+" = "+numero*i);
            }
        }
    }
}