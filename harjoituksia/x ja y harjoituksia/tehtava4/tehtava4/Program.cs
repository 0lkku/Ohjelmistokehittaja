using System;

namespace tehtava4
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
            Console.Write("Anna neljäs luku: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Anna viides luku: ");
            int b = int.Parse(Console.ReadLine());

            int num = Math.Max(x, y);
            int num1 = Math.Max(z, num);
            int num2 = Math.Max(a, num1);
            int numS = Math.Max(b, num2);

            Console.WriteLine("Luku " + numS + " on suurin antamastasi viidestä luvusta");
        }
    }
}
