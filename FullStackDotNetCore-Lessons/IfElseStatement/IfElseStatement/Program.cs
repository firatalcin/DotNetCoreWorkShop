using System;

namespace IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1 - Karar Mekanizmaları (if-else if-else)
            //Console.Write("Bir sayi giriniz: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 10)
            //{
            //    Console.WriteLine("Sayı 10'dan büyüktür.");
            //}
            //else if (number < 10)
            //{
            //    Console.WriteLine("Sayı 10'dan küçüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 10'a eşittir.");
            //}
            //if(number % 2 == 0)
            //{
            //    Console.WriteLine(number + " çift sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " tek sayıdır.");
            //}
            #endregion

            #region Ders 2 - Karar Mekanizmaları (Switch-Case)
            Console.WriteLine("Hangi meyveyi almak istiyorsunuz ?");
            string fruit = Console.ReadLine();
            switch (fruit)
            {
                case "elma":
                    Console.WriteLine("1 lira");
                    break;
                case "armut":
                    Console.WriteLine("2 lira");
                    break;
                case "muz":
                    Console.WriteLine("3 lira");
                    break;
                default:
                    Console.WriteLine("Manavda kalmamıştır.");
                    break;
            }
            #endregion


        }
    }
}
