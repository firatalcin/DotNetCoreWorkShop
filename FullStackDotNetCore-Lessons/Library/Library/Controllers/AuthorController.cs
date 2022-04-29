using Library.Context;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {

        public IActionResult AuthorList()
        {

            using (MyDbContext context = new MyDbContext())
            {
                var list = context.Authors.Where(x => x.Status != Enums.DataStatus.Delete).ToList();
                return View(list);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            using (MyDbContext context = new MyDbContext())
            {
                context.Authors.Add(author);
                context.SaveChanges();
                return RedirectToAction("AuthorList");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var author = context.Authors.FirstOrDefault(x => x.Id == id);
                return View(author);
            }
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            using (MyDbContext context = new MyDbContext())
            {
                author.Status = Enums.DataStatus.Update;
                author.ModifiedDate = DateTime.Now;
                context.Authors.Update(author);
                context.SaveChanges();
                return RedirectToAction("AuthorList");
            }
        }

       
        public IActionResult Delete(int id)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var author = context.Authors.FirstOrDefault(x => x.Id == id);
                author.Status = Enums.DataStatus.Delete;
                author.ModifiedDate = DateTime.Now;
                context.SaveChanges();
                return RedirectToAction("AuthorList");
            }
        }


    }
}
