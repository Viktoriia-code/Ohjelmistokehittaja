internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nyt on: ");
        var date = DateTime.Now;
        string paiva = date.ToString("d");
        string aika = date.ToString("hh:mm:ss tt");
        Console.Write(paiva + " " + aika);
    }
}