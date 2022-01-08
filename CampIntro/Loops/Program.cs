using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {         

            //array - dizi

            string[] kurslar = new string[] 
            { 
                "Yazılım Geliştirici Yerleştirme Kampı" , 
                "Programlamaya başlangıç için temel kurs", 
                "Java",
                "Python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }

           
        }
    }
}
