using Library.Context;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Library.Controllers
{
    public class BookTypeController : Controller
    {

        public IActionResult BookTypeList()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var list = context.BookTypes.ToList();
                return View(list);
            }               
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            using (MyDbContext context = new MyDbContext())
            {
                context.BookTypes.Add(bookType);
                context.SaveChanges();
                return RedirectToAction("BookTypeList");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var bookType = context.BookTypes.FirstOrDefault(x => x.Id == id);
                return View(bookType);
            }
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            using (MyDbContext context = new MyDbContext())
            {
                bookType.Status = Enums.DataStatus.Update;
                bookType.ModifiedDate = DateTime.Now;
                context.BookTypes.Update(bookType);
                context.SaveChanges();
                return RedirectToAction("BookTypeList");
            }
        }

        public IActionResult HardDelete(int id)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var bookType = context.BookTypes.FirstOrDefault(x => x.Id == id);
                context.BookTypes.Remove(bookType);
                context.SaveChanges();
                return RedirectToAction("BookTypeList");
            }
        }
    }
}
