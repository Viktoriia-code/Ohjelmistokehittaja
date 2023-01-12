internal class Program
{
    private static void Main(string[] args)
    {
        int luku = 50;
        float neliojuuri = (float)Math.Sqrt(luku);
        Console.WriteLine("Neliöjuuri luvusta {0} on {1}.", luku, neliojuuri.ToString());
    }
}