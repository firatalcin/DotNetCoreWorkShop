using Library.Models;
using System.Collections.Generic;

namespace Library.RepositoryPattern.Abstract
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> GetBooks();
    }
}
