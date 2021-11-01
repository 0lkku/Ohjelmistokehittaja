using System;

namespace tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta pistettä sait? (1-9)");
            int vast = int.Parse(Console.ReadLine());

            switch (vast)
            {
                case (1):
                case (2):
                case (3):
                    {
                        vast *= 10;
                        Console.WriteLine("");
                        Console.WriteLine("Bonuksella pisteesi ovat: " + vast);
                        break;
                    }
                case (4):
                case (5):
                case (6):
                    {
                        vast *= 100;
                        Console.WriteLine("");
                        Console.WriteLine("Bonuksella pisteesi ovat: " + vast);
                        break;
                    }
                case (7):
                case (8):
                case (9):
                    {
                        vast *= 1000;
                        Console.WriteLine("");
                        Console.WriteLine("Bonuksella pisteesi ovat: " + vast);
                        break;
                    }
                default:
                    Console.WriteLine("ERROR ERROR ERROR 1-9???");
                    break;
            }
        }
    }
}
