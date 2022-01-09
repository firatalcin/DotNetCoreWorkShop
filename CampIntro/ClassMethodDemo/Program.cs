using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Fırat";
            musteri1.Soyad = "Alçın";
            musteri1.HesapNumarasi = "12345";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Enes";
            musteri2.Soyad = "Çiçek";
            musteri2.HesapNumarasi = "67894";

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,
                musteri2
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteriler);
        }
    }
}
