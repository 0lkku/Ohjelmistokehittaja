using System;

namespace tehtava1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Anna numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen numero: ");
            int y = int.Parse(Console.ReadLine());

            int numS = Math.Max(x, y);
            int numP = Math.Min(x, y);

            Console.WriteLine("Suuruusjärjestys numeroillesi on " + numP + ", " + numS);

            Console.WriteLine("");
            Console.WriteLine("Haluatko kokeilla uudestaan?");
            string vast = Console.ReadLine();

            if ((vast == "kyllä") || (vast == "Kyllä"))
            {
               Main();
            } else
            {
                
            }
        }
    }
}
