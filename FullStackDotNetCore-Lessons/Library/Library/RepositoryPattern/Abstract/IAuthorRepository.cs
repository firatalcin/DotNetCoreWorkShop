using Library.Dto;
using Library.Models;
using System.Collections.Generic;

namespace Library.RepositoryPattern.Abstract
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
