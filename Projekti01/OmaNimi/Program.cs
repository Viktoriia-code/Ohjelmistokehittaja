internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Anna etunimesi: ");
        string enimi = Console.ReadLine();
        Console.Write("Anna sukunimesi: ");
        string snimi = Console.ReadLine();
        Console.WriteLine("Heippa, " + enimi + " " + snimi);
        Console.WriteLine("Heippa {0} {1}", enimi, snimi);
    }
}