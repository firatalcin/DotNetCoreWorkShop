using System;

namespace Library.Models
{
    public class Operation : BaseEntity
    {
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Relational Property

        public Student Student { get; set; }
        public Book Book { get; set; }
    }
}
