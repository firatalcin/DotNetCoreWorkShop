using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Student : User
    {
        public Student(string  _schoolNumber)
        {
            SchoolNumber = _schoolNumber;
        }
        public string ClassRoom { get; set; }
        public string SchoolNumber { get; set; }
        public void DoHomework()
        {
            Console.WriteLine("Ödev yapılıyor");
        }
    }
}
