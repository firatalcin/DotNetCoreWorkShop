﻿using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NTierOOPApp.Web.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerManager customerManager = new(new CustomerDal());
        private JobManager jobManager = new JobManager(new JobDal());

        public IActionResult Index()
        {
            var list = customerManager.GetCustomersListWithJob();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            List<SelectListItem> values = (from x in jobManager.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult result = customerValidator.Validate(customer);
            if (result.IsValid)
            {
                customerManager.Add(customer);
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
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> values = (from x in jobManager.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var customer = customerManager.Get(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerManager.Update(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = customerManager.Get(id);
            customerManager.Remove(customer);
            return RedirectToAction("Index");
        }
    }
}