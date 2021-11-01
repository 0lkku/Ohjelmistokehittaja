using System;

namespace tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitä haluat syöttää (kokonaisluvun, double-luvun vai merkkijonon)?");
            string vast = Console.ReadLine();

            switch (vast)
            {
                case ("merkkijono"):
                    Console.WriteLine("");
                    Console.WriteLine("Syötä Merkkijono");
                    string kirj1 = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine(kirj1 + "*");
                    break;
                case ("kokonaisluku"):
                    Console.WriteLine("");
                    Console.WriteLine("Syötä kokonaisluku");
                    int kirj2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(kirj2 += 1);
                    break;
                case ("double luku"):
                    Console.WriteLine("");
                    Console.WriteLine("Syötä Double-Luku");
                    int kirj3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(kirj3 *= 2);
                    break;
                default:
                    Console.WriteLine("Syöttä kokoluku, double luku tai merkkijono!");
                    break;

            }
        }
    }
}
