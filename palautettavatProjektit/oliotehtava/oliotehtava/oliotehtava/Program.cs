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

            Console.WriteLine("Mitä haluat tehdä? Selata, Lainata, Palauttaa vai Poistua");
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
                        Console.Clear();
                        Console.WriteLine("Nähdään uudestaan taas pian!");
                    break;

                default:
                    goto KYSY;
            }

            void Lainaa()
            {
                Console.WriteLine("Anna lainattavasi kirjan tunnus");
                string laina = Console.ReadLine();

                switch (laina)
                {
                    case ("1"):
                        kirja1.lainaustarkastus();
                        break;

                    case ("2"):
                        kirja2.lainaustarkastus();
                        break;

                    case ("3"):
                        kirja3.lainaustarkastus();
                        break;

                    case ("4"):
                        kirja4.lainaustarkastus();
                        break;



                    default:
                        Console.WriteLine("Virheellinen tunnus");
                        break;
                }

            }

            void Selaa()
            {
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

                Kysynta();
            }

            void Palauta()
            {
                Console.WriteLine("Syötä palautettavasi kirjan tunnus");
                string tunnus = Console.ReadLine();

                switch (tunnus)
                {
                    case ("1"):
                        kirja1.Palautus();
                        break;
                    case ("2"):
                        kirja2.Palautus();
                        break;
                    case ("3"):
                        kirja3.Palautus();
                        break;
                    case ("4"):
                        kirja4.Palautus();
                        break;

                    default:
                        Console.WriteLine("Virheellinen tunnus");
                        break;
                }
                Kysynta();
            }



            }
        }
    }
}
