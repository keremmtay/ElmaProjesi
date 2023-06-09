using ElmaProjesi.DataAccessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using ElmaProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ElmaProjesi.Controllers
{
    public class HomeController : Controller
    {

        ISubCategoryRepository _subCategoryRepository;
        public HomeController(ISubCategoryRepository subCategoryRepository)
        {

            _subCategoryRepository = subCategoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Help()
        {
            return View();
        }
        public IActionResult List(string category)
        {
            return View("SubCategories", _subCategoryRepository.GetBySubCategoriesByCategoryUrl(category));
        }
        public IActionResult GiveService() 
        {
            return View();
        }

        public IActionResult TeklifAlModal(string category)
        {
            return View();
        }
    }
}