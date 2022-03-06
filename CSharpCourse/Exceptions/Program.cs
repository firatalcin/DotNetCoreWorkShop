using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string[] student = new string[3] { "Engin", "Derin", "Salih" };
            //    student[3] = "Ahmet";
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                Found();
            }
            catch (RecordNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            HandleException(()=>
            {
                Found();
            });
            
        }

        private static void HandleException(Action action)
        {
            try
            {
               action.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Found()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }
    }
}
