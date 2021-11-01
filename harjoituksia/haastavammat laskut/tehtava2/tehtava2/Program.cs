using System;

namespace tehtava2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna Celsius");
            float Cel = float.Parse(Console.ReadLine());
            float fah = Cel * 1.8f + 32;
            Console.WriteLine("");
            Console.WriteLine("Fahrenheitti luku on: " + fah);

        }
    }
}
