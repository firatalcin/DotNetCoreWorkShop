﻿using EfWebApp.Data.Context;
using EfWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EfWebApp.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            EfAppContext context = new EfAppContext();

            //context.Products.Add(new Data.Entities.Product
            //{
            //    Name = "Telefon",
            //    Price = 6500
            //});

            var product = context.Products.Find(1);
            product.Price = 7500;
            context.Products.Update(product);
           
            context.SaveChanges();

            return View();
        }       
    }
}
