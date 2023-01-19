using System;

namespace SyottoValinta
{
    class Program
    {
        static void Main(string[] args)
        {
            int kluku;
            double dluku;
            string mjono, syote;
            syottoalku:
            Console.WriteLine("Minkä tyyppisen tiedon haluat syöttää (double, int, string (d/i/s)): ");
            syote = Console.ReadLine();
            if (syote == "s" || syote == "d" || syote == "i" || syote == "S" || syote == "D" || syote == "I")
            {
                switch (syote)
                {
                    case "s":
                    case "S":
                        Console.Write("Syötä merkkijono: ");
                        mjono = Console.ReadLine();
                        mjono += "*";
                        Console.WriteLine("Uusi merkkijono on: " + mjono);
                        break;
                    case "d":
                    case "D":
                    doublealku:
                        Console.Write("Syötä doubleluku: ");
                        try
                        {
                            dluku = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Annoit luvun " + dluku + " ja tulos on " + (dluku + 1));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Ole hyvä ja anna doubleluku!");
                            goto doublealku;
                        }
                        break;
                    case "i":
                    case "I":
                    intalku:
                        Console.Write("Syötä kokonaisluku: ");
                        try
                        {
                            kluku = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Annoin luvun " + kluku + " ja tulos on " + (kluku + 1));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Ole hyvä ja anna kokonaisluku!");
                            goto intalku;
                        }
                        break;
                    default:
                        Console.WriteLine("Jos päädyt tänne, jossakin on virhe!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Annoit väärän syötteen. Anna vain kirjain: (d/i/s): ");
                goto syottoalku;
            }
        }
    }
}