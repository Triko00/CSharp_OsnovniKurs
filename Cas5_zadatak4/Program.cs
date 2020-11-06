using System;
using System.ComponentModel;

namespace Cas5_zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi rec: ");
            string rec = Console.ReadLine();
            Console.WriteLine("Unesi prvo slovo: ");
            char slovo = Convert.ToChar(Console.ReadLine());

            if (slovo == rec[0])
            {
                Console.WriteLine("Prvo slovo je jednako slovu koje si napisao.");
            }
            else
            {
                Console.WriteLine("Prvo uneto slovo nije jednako prvom slovu koje si napisao.");
            }
        }
    }
}
