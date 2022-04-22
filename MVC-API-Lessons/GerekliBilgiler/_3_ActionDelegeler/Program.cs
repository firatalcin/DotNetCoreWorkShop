using System;

namespace _3_ActionDelegeler
{
    public class Program
    {
        //func, action, predicate
        static void Main(string[] args)
        {
            Action action = new Action(() =>
            {
                Console.WriteLine("Selam Fırat");
            });

            //Action<string> action2 = new Action<string>(SelamVer2);
            //action2 += SelamVer3;
            //action2.Invoke("Fırat");

            Action<string> action2 = new Action<string>(name =>
            {
                Console.WriteLine("Selam " + name);
            });

            action2.Invoke("Fırat");
        }

        private static void SelamVer3(string name)
        {
            Console.WriteLine("Selam " + name + " Nasılsın ?");
        }

        private static void SelamVer2(string name)
        {
            Console.WriteLine("Selam " + name);
        }

        private static void SelamVer()
        {
            Console.WriteLine("Selam Fırat");
        }
    }
}
