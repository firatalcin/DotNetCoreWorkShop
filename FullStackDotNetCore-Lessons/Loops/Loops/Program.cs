using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1 - While Döngüsü
            //int index = 0;
            //while (index < 10)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}
            #endregion

            #region Ders 2 - For Döngüsü
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Ders 3 - Do While Döngüsü
            //int index = 0;
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}while (index < 20);
            #endregion

            #region Ders 4 - Break ve Continue Keyword'leri
            //for (int i = 0; i < 10; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        continue; // i == 3 geçip devam et
            //    }
            //    else if (i % 9 == 0)
            //    {
            //        break; // Döngüyü durdur
            //    }
            //}
            #endregion

            #region Ders 5 - Foreach Döngüsü
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
