using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Entities.Models
{
    public class FluentApi_Book
    {

        public int BookId { get; set; }
        public string BookName { get; set; }
        public double BookPrice { get; set; } 
        public string ISBN { get; set; }

    
        

    }
}
