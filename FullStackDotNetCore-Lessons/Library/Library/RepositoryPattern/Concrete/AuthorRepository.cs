using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Library.RepositoryPattern.Concrete
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
       

        public List<AuthorDto> SelectAuthorDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new AuthorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id
            }).ToList();
        }
    }
}
