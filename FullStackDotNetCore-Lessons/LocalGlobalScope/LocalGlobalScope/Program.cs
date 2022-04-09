using System;

namespace LocalGlobalScope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1 - Local Alan
            //try
            //{
            //    int age = 14;
            //    Console.WriteLine(age);
            //}
            //catch (Exception ex)
            //{
            //age farklı scope'da tanımlandığı için field'a ulaşılamıyor.
            //}
            #endregion

            #region Ders 2 - Global Alan
            int age = 14;
            try
            {
                Console.WriteLine(age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(age); //global tanımlı olunca alt seviyede ki tüm scopelarda görünür.
            }   
            #endregion
        }
    }
}
