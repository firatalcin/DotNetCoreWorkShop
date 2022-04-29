using Library.Context;
using Library.Dto;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        MyDbContext context = new MyDbContext();

        public IActionResult BookList()
        {
            var list = context.Books.Where(x => x.Status != Enums.DataStatus.Delete).Include(x => x.Author).Include(x => x.BookType).ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            var authors = context.Authors.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new AuthorDto() {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id
            }).ToList();

            var bookTypes = context.BookTypes.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new BookTypeDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();

            return View((new Book(), authors, bookTypes));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return RedirectToAction("BookList");
        }

        public IActionResult Edit(int id)
        {
            var book = context.Books.SingleOrDefault(x => x.Id == id);

            var authors = context.Authors.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new AuthorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id
            }).ToList();

            var bookTypes = context.BookTypes.Where(x => x.Status != Enums.DataStatus.Delete).Select(x =>
            new BookTypeDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();

            return View((book,authors,bookTypes));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            book.Status = Enums.DataStatus.Update;
            book.ModifiedDate = System.DateTime.Now;
            context.Books.Update(book);
            context.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
