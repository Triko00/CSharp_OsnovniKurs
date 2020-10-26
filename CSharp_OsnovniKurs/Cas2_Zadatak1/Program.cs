using System;

namespace Domaci_rad
{
    class Program
    {
        static void Main(string[] args)
        {
            int absX;

            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                absX = -x;
                Console.WriteLine("Suprotni broj od " + x + " je " + absX + ".");
            }
            else
            {
                absX = x;
                Console.WriteLine("Broj je vec pozitivan. (Inace je takodje " + absX + ".)");
            }
        }
    }
}
