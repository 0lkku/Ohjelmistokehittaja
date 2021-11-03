using System;

namespace ClassOpiskelu
{
    class Program
    {
        static void Main(string[] args)
        {
           /* peruslaskut joulupukki = new peruslaskut();
              int x1 = joulupukki.Summa(4, 5);
              int x2 = joulupukki.Erotus(4, 5);
              int x3 = joulupukki.Kerto(4, 5);
              double x4 = joulupukki.Jako(4, 5);
              Console.WriteLine("Lukujenn {0} {1} summa, erotus, kerto, jako ovat {2}, {3}, {4}, {5}", 4, 5, x1, x2, x3, x4);*/
            Pankkitili jyri = new Pankkitili("Jyri", "Opettaja", "123456-1234", 100.10);
            Console.WriteLine(jyri.NaytaSaldo());
            jyri.Pano(200);
            Console.WriteLine(jyri.NaytaSaldo());
            jyri.Otto(50.51);
            Console.WriteLine(jyri.NaytaSaldo());
            jyri.Otto(2000);
            Console.WriteLine(jyri.NaytaSaldo());

        }
    }
}
