using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class Account
    {
        string _userName;

        public string UserName
        { 
            get { return _userName; } 
            set 
            {
                if(value.Length > 3)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("Lütfen kullanıcı adınızı 3 karakterden fazla giriniz.");
                    Program.Main();
                }
            } 
        }

        public string Password { get; set; }
    }
}
