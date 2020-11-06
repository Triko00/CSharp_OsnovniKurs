using System;

namespace Cas5_zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            ime = char.ToUpper(ime[0]) + ime.Substring(1).ToLower();

            Console.WriteLine("Uneto ime je " + ime + ".");

        }
    }
}
