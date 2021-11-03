using System;

namespace tehtava3
{
    class Program
    {
      
        static void Main()
        {
            static string lasku(float luku1, float luku2)
            {
                float summa = luku1 + luku2;
                float erotus = luku1 - luku2;
                float kerto = luku1 * luku2;
                float jako = luku1 / luku2;

                string muuttaja = String.Format("{0} {1} {2} {3}", summa, erotus, kerto, jako);
                return muuttaja;
            }
            Console.WriteLine("Anna luku 1.");
            float luku1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku 2.");
            float luku2 = float.Parse(Console.ReadLine());




            Console.WriteLine(lasku(luku1, luku2));
        }
    }
}
