using System;

namespace Cas4zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prirodan broj: ");
            int maxBroj = int.Parse(Console.ReadLine());

            int zbir = 0;

            for (int i = 0; i < maxBroj; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Paran broj: " + i);
                    zbir = zbir + i;
                }
            }
            Console.WriteLine("Zbir parnih brojeva manjih od " + maxBroj + " je " + zbir + ".");
        }
    }
}
