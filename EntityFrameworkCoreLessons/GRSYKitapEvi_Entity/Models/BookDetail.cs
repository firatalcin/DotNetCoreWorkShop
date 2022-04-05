using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Entities.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }
        [Required]
        public int NumberOfChapter { get; set; }
        [Required]
        public int NumberOfPage { get; set; }
        public double Weight { get; set; }

        public Book Book { get; set; }

    }
}
