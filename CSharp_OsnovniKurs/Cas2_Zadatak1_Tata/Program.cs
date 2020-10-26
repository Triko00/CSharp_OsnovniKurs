using System;

namespace Domaci_rad_Tata
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Unesi ceo broj: ");
            int x = int.Parse(Console.ReadLine());

            // Output
            Console.WriteLine("Apsolutna vrednost unetog broja " + x + " je " + Abs(x));
        }

        static uint Abs(int x)
        {
            return x >= 0 ? (uint)x : (uint)-x;
        }
    }
}
