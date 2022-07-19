using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace NTierOOPApp.Web.Controllers
{
    public class JobController : Controller
    {
        private JobManager jobManager = new(new JobDal());

        [HttpGet]
        public IActionResult Index()
        {
            var list = jobManager.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            JobValidator validationRules = new JobValidator();
            ValidationResult result = validationRules.Validate(job);
            if (result.IsValid)
            {
                jobManager.Add(job);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var product = jobManager.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            jobManager.Update(job);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteJob(int id)
        {
            var job = jobManager.Get(id);
            jobManager.Remove(job);
            return RedirectToAction("Index");
        }
    }
}