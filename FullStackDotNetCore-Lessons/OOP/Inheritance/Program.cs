using Inheritance.Models;
using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("144");
            student.FirstName = "Fırat";
            student.LastName = "Alçın";
            Console.WriteLine(student.GetFullName());
        }
    }
}
