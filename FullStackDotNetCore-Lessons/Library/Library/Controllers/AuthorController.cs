﻿using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Library.Controllers
{
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
            return RedirectToAction("AuthorList");
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
            return RedirectToAction("AuthorList");
        }

       
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("AuthorList");
        }


    }
}
