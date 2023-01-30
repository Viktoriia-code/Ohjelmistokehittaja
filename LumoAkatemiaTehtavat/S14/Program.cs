using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* S14. Muuta edellistä tehtävää siten, että lasket parittomien lukujen summan */
            int[] fibo = new int[10];
            int summa = 0;
            fibo[0] = 0;
            fibo[1] = 1;
            for (int i = 2; i < 10; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            Console.Write("Fibonaccin numerot ovat: [");
            for (int j = 0; j < 10; j++)
            {
                if (fibo[j] % 2 != 0)
                {
                    summa += fibo[j];
                }
            }
            Console.WriteLine("Parittomien Fibonaccin lukujen summa on {0}", summa);
        }
    }
}