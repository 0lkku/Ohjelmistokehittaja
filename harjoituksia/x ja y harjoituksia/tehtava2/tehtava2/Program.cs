using System;

namespace tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            int z = int.Parse(Console.ReadLine());

            int num = Math.Max(x, y);
            int numS = Math.Max(z, num);

            Console.WriteLine("Luku " + numS + " on suurin kolmesta luvusta");
        }
    }
}
