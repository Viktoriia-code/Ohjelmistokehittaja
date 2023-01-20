using System;

namespace Ikalause
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjoita ohjelma, joka kysyy käyttäjän ikää (esim. 25) ja tulostaa konsoliin: ”25 – näytät ikäistäsi nuoremmalta”
            Console.WriteLine("Har. 11. Kysyy käyttäjän ikää ja tulostaa konsoliin lause.");
            Console.Write("Anna sinun ikä: ");
            int ika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} – näytät ikäistäsi nuoremmalta.", ika);
        }
    }
}