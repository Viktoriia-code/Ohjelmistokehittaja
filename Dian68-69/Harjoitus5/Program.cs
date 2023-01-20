using System;

namespace Nimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pyytää käyttäjän nimeä ja palauttaa viestin: Hei *nimi*");
            string viesti;
            Console.Write("Anna nimesi: ");
            viesti = Console.ReadLine();
            Console.WriteLine("Hei " + viesti);
        }
    }
}