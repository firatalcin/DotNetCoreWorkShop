using System.Collections.Generic;

namespace Library.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string PageCount { get; set; }
        public int AuthorId { get; set; }
        public int BookTypeId { get; set; }

        //Relational Property

        public Author Author { get; set; }
        public BookType BookType { get; set; }
        public List<Operation> Operations { get; set; }

    }
}
