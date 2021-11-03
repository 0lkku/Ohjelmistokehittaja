using System;

namespace tehtava12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna numero isompi kuin 10");
            float a = float.Parse(Console.ReadLine());
            if(a < 10)
            {
            
                Console.WriteLine("");
                Main();
            }
            else
            {
                for (float i = 1; i <= a; i++)
                {
                    Console.WriteLine(i + " " + a);
                }
            }
        }
    }
}
