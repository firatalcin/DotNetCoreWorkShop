using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string city = "Ankara";
            //Console.WriteLine(city[0]);

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            //string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(String.Format(city + " " + city2));


            string sentence = "My name is Fırat Alçın";

            var result = sentence.Length; //uzunluk verir.
            var result2 = sentence.Clone(); // kopyasını alır
            var result3 = sentence.EndsWith("n");
            var result4 = sentence.StartsWith("My");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.LastIndexOf(" ");
            var result7 = sentence.Insert(0, "Hello ");
            var result8 = sentence.Substring(3,4); //parçalama
            var result9 = sentence.ToLower(); 
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace(" ", "-");
            var result12 = sentence.Remove(2,5);
            Console.WriteLine(result5);
        }
    }
}
