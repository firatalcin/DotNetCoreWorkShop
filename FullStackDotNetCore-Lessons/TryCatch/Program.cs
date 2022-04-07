using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1 - Try Catch Blokları
            //try
            //{
            //    Console.WriteLine("1. sayıyı giriniz: ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2. sayıyı giriniz: ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(number1 + number2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli formatta giriş yapınız.");
            //} 
            #endregion

            #region Ders 2 - Çoklu Catch Kullanımı
            //try
            //{
            //    Console.WriteLine("1. sayıyı giriniz: ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2. sayıyı giriniz: ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(number1 + number2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli formatta giriş yapınız.");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölünemez.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Ders 3 - Finally Sözcüğü
            //try
            //{
            //    Console.WriteLine("1. sayıyı giriniz: ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2. sayıyı giriniz: ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(number1 + number2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli formatta giriş yapınız.");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölünemez.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Burası her durumda okunur.");
            //}
            #endregion

            #region Ders 4 - Breakpoint Kullanımı
            try
            {
                Console.WriteLine("1. sayıyı giriniz: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number1 + number2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli formatta giriş yapınız.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra bölünemez.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}
