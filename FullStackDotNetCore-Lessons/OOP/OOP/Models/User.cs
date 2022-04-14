using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public void Selamla(string userName)
        {
            Console.WriteLine($"{userName} sizi selamlıyor");
        }
    }
}
