using System;

namespace DomaciRad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resenje;

            int x = int.Parse(Console.ReadLine());
            Char znak = Convert.ToChar(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(znak == '+')
            {
                resenje = x + y;
                Console.WriteLine(resenje);
            }

            else if (znak == '-')
            {
                resenje = x - y;
                Console.WriteLine(resenje);
            }

            else if (znak == '*')
            {
                resenje = x * y;
                Console.WriteLine(resenje);
            }

            else if (znak == '/')
            {
                resenje = x / y;
                Console.WriteLine(resenje);
            }
        }
    }
}
