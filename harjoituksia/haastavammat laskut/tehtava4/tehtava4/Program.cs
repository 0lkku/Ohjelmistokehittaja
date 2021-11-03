using System;

namespace tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {
            static double lasku(float luku1, float luku2)
            {
                return luku1 % luku2;
            }


            Console.WriteLine("Anna kokonaisluku");
            float luku1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna jakojäänetettävä luku");
            float luku2 = float.Parse(Console.ReadLine());

            Console.WriteLine(lasku(luku1, luku2));



        }
    }
}
