internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kirjoita sinun nimi, kiitos!");
        Console.Write("Minun nimi on: ");
        string nimi = Console.ReadLine();
        Console.WriteLine("Heippa {0}", nimi);
    }
}