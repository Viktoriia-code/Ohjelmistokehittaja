internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nyt on: ");
        var date = DateTime.Now;
        Console.Write(date.ToString("F"));
    }
}