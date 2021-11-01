using System;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            static int laskeYhteen(int luku1, int luku2)
            {
                return (luku1 + luku2);
            }

            int luku1, luku2, summa;

            Console.WriteLine("Anna numero");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen numero");
            luku2 = int.Parse(Console.ReadLine());

            summa = laskeYhteen(luku1, luku2);
            Console.WriteLine(summa);
        }
    }
}
