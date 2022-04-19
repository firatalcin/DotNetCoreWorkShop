using System;

namespace Lesson_4_Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> yazilimcilar = new MyDictionary<int, string>();
            yazilimcilar.Add(1, "Fırat");
            yazilimcilar.Add(2, "Engin");

            foreach (var item in yazilimcilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
