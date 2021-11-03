using System;

namespace tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku");
            float a = float.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("----");
                Console.WriteLine(a * i);
            }
        }
    }
}
