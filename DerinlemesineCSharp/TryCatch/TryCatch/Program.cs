using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hata Yönetimi

            //İki sayının çarpımını bulan uygulamayı yazınız
            // Mantık Hatası
            // Syntax Hatası
            // Çalışma Zamanı Hatası

            try
            {
                Console.WriteLine("1. sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(sayi1 * sayi2);
            }
            catch (FormatException)
            {

                Console.WriteLine("Hatalı giriş yaptınız, bir sonra ki denemede sayı giriniz.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra bölünemez");
            }
            catch (Exception ex) // genel hata en sona yazılır
            {
                Console.WriteLine(ex.Message);
            }
            finally // hata alsakta almasakta burası çalışır
            {
                Console.WriteLine("Burası son durak");
            }

           
        }
    }
}
