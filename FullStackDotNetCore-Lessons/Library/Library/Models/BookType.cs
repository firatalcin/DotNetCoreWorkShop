using Library.Models.ModelDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Library.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        //Relational Property

        public List<Book> Books { get; set; }
    }
}
