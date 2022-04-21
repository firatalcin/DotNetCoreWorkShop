using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){TeacherId=1,TeacherName = "Abdullah", TeacherGender = "Man"},
            new Teacher(){TeacherId=2,TeacherName = "Esma", TeacherGender = "Woman"},
            new Teacher(){TeacherId=3,TeacherName = "Hakan", TeacherGender = "Man"},
            new Teacher(){TeacherId=4,TeacherName = "Feyza", TeacherGender = "Woman"},
        };

        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }

        public IActionResult DeleteTeacher(int id)
        {
            var teacher = teachers.FirstOrDefault(x => x.TeacherId == id);
            return View(teacher);
        }

        public PartialViewResult TeacherInfoPartial()
        {
            return PartialView();
        }
    }
}
