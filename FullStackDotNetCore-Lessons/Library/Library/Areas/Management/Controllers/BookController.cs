using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    public class BookController : Controller
    {
        MyDbContext _db;
        IBookRepository _repoBook;
        IAuthorRepository _repoAuthor;
        IBookTypeRepository _repoBookType;

        public BookController(MyDbContext db, IBookRepository repoBook, IAuthorRepository repoAuthor, IBookTypeRepository repoBookType)
        {
            _db = db;
            _repoBook = repoBook;
            _repoAuthor = repoAuthor;
            _repoBookType = repoBookType;
        }

        public IActionResult BookList()
        {
            var list = _repoBook.GetBooks();
            return View(list);
        }

        public IActionResult Create()
        {
            var authors = _repoAuthor.SelectAuthorDto();

            var bookTypes = _repoBookType.SelectBookTypeDto();

            return View((new Book(), authors, bookTypes));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _repoBook.Add(book);
            return RedirectToAction("BookList", "Book", new {name = "Management"});
        }

        public IActionResult Edit(int id)
        {
            var book = _db.Books.SingleOrDefault(x => x.Id == id);

            var authors = _db.Authors.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new AuthorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id
            }).ToList();

            var bookTypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new BookTypeDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();

            return View((book, authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            book.Status = Enums.DataStatus.Update;
            book.ModifiedDate = System.DateTime.Now;
            _db.Books.Update(book);
            _db.SaveChanges();
            return RedirectToAction("BookList", "Book", new { name = "Management" });
        }
    }
}
