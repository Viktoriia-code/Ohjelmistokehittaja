using System;

namespace TuumatSenteiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // P10. Tee ohjelma, joka muuntaa tuumat senteiksi
            Console.WriteLine("Muuntaa tuumat senteiksi.");
            Console.Write("Anna tuumien määrä: ");
            int tuumat = Convert.ToInt32(Console.ReadLine());
            float sentit = (float)(tuumat * 2.54);
            Console.WriteLine($"{tuumat} tuumaa on {sentit} senttiä.");
        }
    }
}