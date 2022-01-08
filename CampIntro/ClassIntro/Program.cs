using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demirog";
            kurs1.izlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.egitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.kursAdi + " - " + item.egitmen);
            }

            //Console.WriteLine(kurs1.kursAdi + " - " + kurs1.egitmen);
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
