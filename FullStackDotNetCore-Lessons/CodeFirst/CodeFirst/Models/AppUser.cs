using CodeFirst.Enums;
using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        // Relational Property

        public virtual AppUserDetail AppUserDetail { get; set; }

        public virtual List<Order>  Orders { get; set; }
    }
}
