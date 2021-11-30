using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliotehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa kirjastoon!");
            Console.WriteLine("");

            Kirjat kirja1 = new Kirjat("Olio", "Topunen", "113", "1", "Ei");
            Kirjat kirja2 = new Kirjat("Mestareiden mestari", "Kampunen", "762", "2", "Ei");
            Kirjat kirja3 = new Kirjat("Koodarin ura", "Keuda Kerava", "1578", "3", "Ei");
            Kirjat kirja4 = new Kirjat("Vanhuksestakin meemikeisari", "Tobasco Man", "420", "4", "Ei");
            Kysynta();
        
        void Kysynta()
        {
        KYSY:

            Console.WriteLine("Mitä haluat tehdä? Selata, Lainata, Palauttaa vai Poistua.");
            string teko = Console.ReadLine();

            switch (teko.ToLower())
            {
                case ("selata"):
                    Selaa();
                    goto KYSY;


                case ("lainata"):
                        Lainaa();
                    goto KYSY;


                case ("palauttaa"):
                    Palauta();
                    break;


                case ("poistua"):
                        Environment.Exit(0);
                    break;

                default:
                        Console.WriteLine("Voi olla että teit kirjoitus virheen");
                        Console.WriteLine("");
                        goto KYSY;
            }

            void Lainaa()
            {
                Console.WriteLine("");
                Console.WriteLine("Anna lainattavasi kirjan tunnus");
                string laina = Console.ReadLine();

                switch (laina)
                {
                    case ("1"):
                            Console.Clear();
                            kirja1.lainaustarkastus();
                            Console.WriteLine("");
                            break;

                    case ("2"):
                            Console.Clear();
                            kirja2.lainaustarkastus();
                            Console.WriteLine("");
                            break;

                    case ("3"):
                            Console.Clear();
                            kirja3.lainaustarkastus();
                            Console.WriteLine("");
                            break;

                    case ("4"):
                            Console.Clear();
                            kirja4.lainaustarkastus();
                            Console.WriteLine("");
                            break;



                    default:
                        Console.WriteLine("Virheellinen tunnus");
                            Console.WriteLine("");
                            break;
                }
                    Kysynta();
            }

            void Selaa()
            {
                    Console.Clear();

                    string[] kirjaT1 = { kirja1.kNimet(), kirja1.kTekija(), kirja1.kSivut(), kirja1.kTunnukset(), "" };
                string[] kirjaT2 = { kirja2.kNimet(), kirja2.kTekija(), kirja2.kSivut(), kirja2.kTunnukset(), "" };
                string[] kirjaT3 = { kirja3.kNimet(), kirja3.kTekija(), kirja3.kSivut(), kirja3.kTunnukset(), "" };
                string[] kirjaT4 = { kirja4.kNimet(), kirja4.kTekija(), kirja4.kSivut(), kirja4.kTunnukset(), "" };


                foreach (string taul1 in kirjaT1)
                {
                    Console.WriteLine(taul1);
                }
                foreach (string taul2 in kirjaT2)
                {
                    Console.WriteLine(taul2);
                }

                foreach (string taul3 in kirjaT3)
                {
                    Console.WriteLine(taul3);
                }

                foreach (string taul4 in kirjaT4)
                {
                    Console.WriteLine(taul4);
                }
                    
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("");
                    Kysynta();
            }

            void Palauta()
            {
                    Console.WriteLine("");
                    Console.WriteLine("Syötä palautettavasi kirjan tunnus");
                string tunnus = Console.ReadLine();

                switch (tunnus)
                {
                    case ("1"):
                            Console.Clear();
                            kirja1.Palautus();
                            Console.WriteLine("");
                            break;
                    case ("2"):
                            Console.Clear();
                            kirja2.Palautus();
                            Console.WriteLine("");
                            break;
                    case ("3"):
                            Console.Clear();
                            kirja3.Palautus();
                            Console.WriteLine("");
                            break;
                    case ("4"):
                            Console.Clear();
                            kirja4.Palautus();
                            Console.WriteLine("");
                            break;

                    default:
                            Console.WriteLine("Virheellinen tunnus");
                            Console.WriteLine("");
                            break;
                }
                Kysynta();
            }



            }
        }
    }
}
