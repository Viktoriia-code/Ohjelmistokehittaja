using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var a = 0;
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(a + 1);
            a = (int)Math.Pow(10, (i+1));
        }
    }
}