using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Teacher : User
    {
        public string[] ClassRooms { get; set; }
        public string Branch { get; set; }
        public void GiveHomework()
        {
            Console.WriteLine("Ödev Verildi");
        }
    }
}
