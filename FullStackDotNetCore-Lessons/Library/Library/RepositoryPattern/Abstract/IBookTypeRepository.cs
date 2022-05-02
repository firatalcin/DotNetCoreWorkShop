using Library.Dto;
using Library.Models;
using System.Collections.Generic;

namespace Library.RepositoryPattern.Abstract
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SelectBookTypeDto();
    }
}
