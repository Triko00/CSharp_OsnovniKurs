using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciRad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resenje;

            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                resenje = 2 / broj;
                Console.WriteLine(resenje);
            }

            else
            {
                resenje = 2 * broj;
                Console.WriteLine(resenje);
            }

            Console.ReadLine();
        }
    }
}
