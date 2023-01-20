using System;

namespace Tofahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //käyttäjä voi antaa Celsius arvon
            Console.WriteLine("Muuttaa Celsius-asteet Fahrenheiteiksi.");
            Console.Write("Anna Celsius-asteet: ");
            int cel = Convert.ToInt32(Console.ReadLine());
            float fah = (float)cel * 9 / 5 + 32;
            Console.WriteLine("Fahrenheit-asteet: {0}", fah);
        }
    }
}