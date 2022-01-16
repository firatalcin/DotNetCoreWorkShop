using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.Id = 1;
            musteri1.TcNo = "22222222222";
            musteri1.MusteriNo = "12345";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.VergiNo = "1234567890"; 
            musteri2.Id = 2;
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.MusteriNo = "54321";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
