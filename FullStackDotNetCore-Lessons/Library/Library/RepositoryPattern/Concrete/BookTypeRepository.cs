using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Library.RepositoryPattern.Concrete
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext db) : base(db)
        {
        }

        public List<BookTypeDto> SelectBookTypeDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new BookTypeDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
