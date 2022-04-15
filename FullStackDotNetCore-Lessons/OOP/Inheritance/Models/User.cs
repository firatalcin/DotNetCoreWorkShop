using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class User
    {
        public User()
        {
            CreatedDate = DateTime.Now;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; }
        private int Sample { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
