using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Entities.Models
{
    public class BookWriter
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public Book Book { get; set; }
        public Writer Writer { get; set; }

    }
}
