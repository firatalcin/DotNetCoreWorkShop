using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class TeacherController : Controller
    {
        List<Branch> branches = new List<Branch>()
        {
            new Branch(){BranchId = 1, BranchName= "Matematik"},
            new Branch(){BranchId = 2, BranchName= "Edebiyat"},
            new Branch(){BranchId = 3, BranchName= "Fizik"},
        };

        public IActionResult AddTeacher()
        {
            ViewBag.Branches = branches;
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        }

        public IActionResult AddTeacherUsingTuple()
        {
            (List<Branch>, Teacher) tuple = (branches, new Teacher());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult AddTeacherUsingTuple([Bind(Prefix ="Item2")] Teacher teacher)
        {
            (List<Branch>, Teacher) tuple = (branches, new Teacher());
            return View(tuple);
        }
    }
}
