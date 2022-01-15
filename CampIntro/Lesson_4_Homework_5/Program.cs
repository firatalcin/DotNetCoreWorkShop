using System;

namespace Lesson_4_Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> yazilimcilar = new MyDictionary<int, string>();
            futbolcular.Add(1, "Fırat");
            futbolcular.Add(2, "Engin");

            foreach (var item in futbolcular.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
