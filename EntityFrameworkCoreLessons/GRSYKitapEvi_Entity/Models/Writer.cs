using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_Entities.Models
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [Required]
        public string WriterName { get; set; }
        [Required]
        public string WriterLastName { get; set; }        
        public string Location { get; set; }
        public DateTime Birthday { get; set; }
        [NotMapped]
        public string FullName 
        {
            get 
            {
                return WriterName + " " + WriterLastName;
            }
        }
    }
}
