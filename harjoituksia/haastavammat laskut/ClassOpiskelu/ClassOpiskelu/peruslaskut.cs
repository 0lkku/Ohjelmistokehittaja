using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOpiskelu
{
    class peruslaskut
    {
        int summa;
        int erotus;
        int kerto;
        double jako;

        public int Summa(int a, int b)
        {
            return a += b;
        }
        public int Erotus(int a, int b)
        {
            return a -= b;
        }
        public int Kerto(int a, int b)
        {
            return a *= b;
        }
        public int Jako(int a, int b)
        {
            return a /= b;
        }





    }
}
