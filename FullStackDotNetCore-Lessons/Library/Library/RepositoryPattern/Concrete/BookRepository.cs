using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
       

        public List<Book> GetBooks()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Delete).Include(x => x.Author).Include(x => x.BookType).ToList();
        }
    }
}
