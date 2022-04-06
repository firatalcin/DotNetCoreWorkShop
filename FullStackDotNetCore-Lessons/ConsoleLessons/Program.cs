using System;

// Dosya yolunu belirten yer
namespace ConsoleLessons
{
    //Sınıf
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1 - Yorum Satırları
            //Yorum Satırları
            //Console.WriteLine("Hello World!");
            /*
                Kodlar yukarıdan aşağıya doğru okunurlar 
                Her satır noktalı vürgüllerle biter

                //System kütüphanesi aracılığıyla yazılır.
                Console.WriteLine("Merhaba Dünya");
            */
            #endregion

            #region Ders 2 - Console Objesi Kullanımı
            //Console.Write("Benim adım: ");
            //Console.WriteLine("Fırat");
            ////Console.Read(); // Enter tuşuna tıklayana kadar burada kalır
            //Console.ReadKey(); // Herhangi bir tuşa basarak geçilebilir.
            //Console.Write("soyadım: ");
            //Console.WriteLine("Alçın"); 
            #endregion

            #region Ders 3 - Ekrandan Input Almak
            ////Console.ReadLine(); //Ekrana bir şey yazılırken bunu okur.
            //Console.Write("İsminiz ne ? ");
            //Console.ReadLine();            
            //Console.Write("Soyadınız ne ? ");
            //Console.ReadLine();          
            //Console.WriteLine("İyi günler"); 
            #endregion

            #region Ders 4 - Değişkene Değer Ataması
            //string name = "Fırat";
            //name = "Rıfat";
            //Console.WriteLine(name); 
            #endregion

            #region Ders 5 - Alınan VEriyi Ekrana Yazdırmak
            //Console.Write("İsminizi giriniz: ");
            //string name = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz: ");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Hoş geldiniz " + name + " " + lastName); 
            #endregion

            #region Ders 6 - Veri Tipleri
            //char first = 'a';
            //byte test = 254;
            //short test2 = 123;
            //int number = 444;
            //float test3 = 11.4F;
            //double test4 = 11.4;
            //decimal des = 15.8M;
            //bool test5 = true; 
            #endregion

            #region Ders 7 - Aritmetik Operatörler
            //int number = 4 + 7;
            //Console.WriteLine(number);

            ////Kısa ve uzun kenarı verilen bir dikdörtgenin alanını hesaplayıp ekrana yazdırın.

            //double kisaKenar = 10;
            //double uzunKenar = 50;
            //double sonuc = kisaKenar * uzunKenar;
            //Console.WriteLine(sonuc);

            //int number2 = 7 % 2;
            //Console.WriteLine(number2);
            //string name = "Fırat ";
            //string surName = "Alçın";
            //string fullName = name + surName;

            //int number3 = 5;
            //number3 = 5 * 2;
            //number3 *= 5;
            //number += 7;
            //Console.WriteLine(number); 
            #endregion

            #region Ders 8 - Mantıksal Operatörler
            //Console.WriteLine("5 ile 7 eşit midir ?");
            //Console.WriteLine(5 == 7);
            //Console.WriteLine("4 büyük müdür 8'den ?");
            //Console.WriteLine(4 > 8);
            //Console.WriteLine("9 küçük eşit midir 9'dan ?");
            //Console.WriteLine(9 <= 9);

            //// soru: Metinsel bir sayı tanımlayalım. consol ekranında bunu bilmeye çalışalım. Bilirsek true bilemezsek false yazdıralım.

            //string secterNumber = "18";
            //Console.Write("Bir sayi giriniz: ");
            //string number = Console.ReadLine();
            //Console.WriteLine(secterNumber == number); 
            #endregion

            #region Ders 9 - Arttırma Ve Azaltma Kullanımı
            //int number = 5;
            //Console.WriteLine(number + 1);
            //Console.WriteLine(number++);
            //Console.WriteLine(++number); 
            #endregion

            #region Ders 10 - Ve Veya Sembolleri
            // // Ve sembolü x > 5 && x < 10
            // // Veya sembolü x > 50 || x == 10

            // /*
            //  Girilen sayı 50 ile 60 arasında olan 5'in katlarından
            //  birisi veya 3'ün katlarından biri ise ekrana true
            //  yazdırın değilse false yazdıran uygulamayı yazınız.
            // */

            // int number = 55;

            //bool isTrue = (number >= 50 && number <= 60) && (number % 5 == 0 || number % 3 == 0);
            // Console.WriteLine(isTrue); 
            #endregion
        }
    }
}
