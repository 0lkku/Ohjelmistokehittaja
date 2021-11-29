using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliotehtava
{
    class Kirjat
    {
        private string kNim, kTeki, kSivu, kTunn, kVara;

        public Kirjat(string kNimi, string kTekija, string kSivumaara, string kTunnukset, string kVaraus)
        {
            kNim = kNimi;
            kTeki = kTekija;
            kSivu = kSivumaara;
            kTunn = kTunnukset;
            kVara = kVaraus;
        }

        public void lainaustarkastus()
        {
            if (kVara == "Ei")
            {
                Console.WriteLine("Kirja on lainattu");


                kVara = "Kyllä";

            }
            else
            {
                Console.WriteLine("Kirjaa ei voi lainata uuestaan");

            }
        }
        public string kNimet()
        {

            if (kVara == "Ei")
            {
                return kNim;
            }
            else
            {
                return "";
            }
        }
        public string Palautus()
        {
            if (kVara == "Kyllä")
            {

                Console.WriteLine("Kirja on palautettu");
                return kVara = "Ei";
            }
            else
            {
                Console.WriteLine("Et ole lainannut kirjaa");
                return "";
            }
        }
        public string kTekija()
        {
            if (kVara == "Ei")
            {
                return kTeki;
            }
            else
            {
                return "";
            }
        }
        public string kSivut()
        {
            if (kVara == "Ei")
            {

                return kSivu;
            }
            else
            {
                return "";
            }
        }
        public string kTunnukset()
            {
                if (kVara == "Ei")
                {
                    return kTunn;
                }
                else
                {
                    return "";
                }
            }
        
    }
}
