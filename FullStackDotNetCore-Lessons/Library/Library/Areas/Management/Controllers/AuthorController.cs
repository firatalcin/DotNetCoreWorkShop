using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class AuthorController : Controller
    {
        IAuthorRepository _repository;

        public AuthorController(IAuthorRepository repository)
        {
            _repository = repository;
        }

       
        public IActionResult AuthorList()
        {
            var list = _repository.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _repository.Add(author);
            return RedirectToAction("AuthorList","Author",new {area = "Management"});
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var updatedAuthor = _repository.GetById(id);
            return View(updatedAuthor);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _repository.Update(author);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }


        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }

    }
}
