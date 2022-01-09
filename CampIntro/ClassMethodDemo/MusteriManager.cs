using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sisteme Eklendi: " + musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sistemden Silindi: " + musteri.Ad);
        }

        public void Listele(Musteri[] musteriler)
        {
            for (int i = 1; i < musteriler.Length + 1; i++)
            {
                Console.WriteLine(i + ". Müşteri: " + musteriler[i-1].Ad + " " + musteriler[i-1].Soyad);
            }
        }
    }
}
