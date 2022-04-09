using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 1 - Dizi Nedir ?
            string[] cities = new string[3];
            cities[0] = "İstanbul";
            cities[1] = "Ankara";
            cities[2] = "İzmir";
            Console.WriteLine(cities[2]);

            string[] cities2 = new string[]
            {
                "İstanbul",
                "Ankara",
                "İzmir"
            };

            int[] number = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(number[4]);
            #endregion
        }
    }
}
