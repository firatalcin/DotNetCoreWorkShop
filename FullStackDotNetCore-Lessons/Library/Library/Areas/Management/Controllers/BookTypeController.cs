using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookTypeController : Controller
    {
        IBookTypeRepository _repoBookType;

        public BookTypeController(IBookTypeRepository repoBookType)
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
            if (!ModelState.IsValid)
            {
                return View(bookType);
            }
            _repoBookType.Add(bookType);
            return RedirectToAction("BookTypeList", "BookType", new {name = "Management"});
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
            return RedirectToAction("BookTypeList", "BookType", new { name = "Management" });
        }

        public IActionResult HardDelete(int id)
        {
            _repoBookType.HardDelete(id);
            return RedirectToAction("BookTypeList", "BookType", new { name = "Management" });

        }
    }
}
