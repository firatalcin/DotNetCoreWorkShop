using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Entities.Models
{
    public class FluentApi_BookDetail
    {
        public int BookDetailId { get; set; }
        public int NumberOfChapter { get; set; }
        public int NumberOfPage { get; set; }
        public double Weight { get; set; }
    }
}
