using System;
using System.ComponentModel;

namespace Cas5_zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Inicijali su: " + ime.ToUpper()[0] + "." + prezime.ToUpper()[0] + ".");
        }
    }
}
