using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Listele()
        {
            var model = new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            };
            
            return View(model);
        }
    }
}
