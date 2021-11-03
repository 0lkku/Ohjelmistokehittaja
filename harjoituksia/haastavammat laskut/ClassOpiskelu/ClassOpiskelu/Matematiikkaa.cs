using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOpiskelu
{
    class Pankkitili
    {
        string tilinumero;
        double saldo;
        string etunimi;
        string sukunimi;

        public Pankkitili(string enimi, string snimi, string tnro, double sdo)
        {
            etunimi = enimi;
            sukunimi = snimi;
            tilinumero = tnro;
            saldo = sdo;
        }
        public double NaytaSaldo()
        {
            return saldo;
        }
        public void Pano(double rahaa)
        {
            saldo += rahaa;
        }
        public void Otto(double rahaa)
        {
            if(rahaa > saldo)
            {
                Console.WriteLine("Köyhä eihä sulla edes oo rahaa");
            }
            else
            {
                saldo -= rahaa;
                NaytaSaldo();
            }
        }
    }
}
