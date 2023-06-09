using ElmaProjesi.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ElmaProjesi.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository _categoryRepository;
        ISubCategoryRepository _subCategoryRepository;
        public CategoryController(ICategoryRepository categoryRepository, ISubCategoryRepository subCategoryRepository)
        {
            _categoryRepository = categoryRepository;
            _subCategoryRepository = subCategoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cleaning()
        {
            return View();
        }
        public IActionResult Renovation()
        {
            return View();
        }
        public IActionResult Transportation()
        {
            return View();
        }
        public IActionResult Repair()
        {
            return View();
        }
        public IActionResult PrivateLesson()
        {
            return View();
        }
        public IActionResult Health()
        {
            return View();
        }
        public IActionResult Organization()
        {
            return View();
        }
    }
}
