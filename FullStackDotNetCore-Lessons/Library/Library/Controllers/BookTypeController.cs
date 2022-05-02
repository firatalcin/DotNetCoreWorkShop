using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Library.Controllers
{
    public class BookTypeController : Controller
    {
        IRepository<BookType> _repoBookType;

        public BookTypeController(IRepository<BookType> repoBookType)
        {
            _repoBookType = repoBookType;
        }

        public IActionResult BookTypeList()
        {
            var list = _repoBookType.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            _repoBookType.Add(bookType);
            return RedirectToAction("BookTypeList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bookType = _repoBookType.GetById(id);
            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            _repoBookType.Update(bookType);
            return RedirectToAction("BookTypeList");
        }

        public IActionResult HardDelete(int id)
        {
            _repoBookType.HardDelete(id);
            return RedirectToAction("BookTypeList");

        }
    }
}
