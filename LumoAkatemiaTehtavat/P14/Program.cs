using System;

namespace FahrenheitCelsiuksiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // P14. Tee ohjelma, joka kysyy käyttäjältä Fahrenheit arvoa ja muuntaa sen Celsiuksiksi
            Console.WriteLine("Muuntaa Fahrenheit arvo Celsiuksiksi.");
            Console.Write("Anna lämpötila Fahrenheit asteina: ");
            int fahr = Convert.ToInt32(Console.ReadLine());
            float cel = ((float)(fahr - 32) * 5) / 9;
            Console.WriteLine($"{fahr} Fahrenheit astetta on {cel} Celsius astetta.");
        }
    }
}