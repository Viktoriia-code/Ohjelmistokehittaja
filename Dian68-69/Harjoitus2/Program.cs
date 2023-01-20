using System;

namespace Tofahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muuttaa Celsius-asteet Fahrenheiteiksi.");
            int cel = 10;
            float fah = (float)cel * 9 / 5 + 32;
            Console.WriteLine("Celsius-asteet: {0}", cel);
            Console.WriteLine("Fahrenheit-asteet: {0}", fah);
        }
    }
}