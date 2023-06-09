using ElmaProjesi.BusinessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using ElmaProjesi.WebUI.Identity;
using ElmaProjesi.WebUI.Models;
using ElmaProjesi.WebUI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ElmaProjesi.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private ICategoryService _categoryService;
        private ISubCategoryService _subCategoryService;
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public AdminController(ICategoryService categoryService, ISubCategoryService subCategoryService, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        #region CATEGORY İŞLEMLERİ


        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model)
        {
            ModelState.Remove("SubCategories");
            if (ModelState.IsValid)
            {
                Category category = new Category()
                {
                    Name = model.Name,
                    Url = model.Url,
                    ImageUrl = model.ImageUrl,
                };


                _categoryService.Create(category);
                return RedirectToAction("CategoryList");
            }
            return View(model);
        }

        public IActionResult CategoryList()
        {
            var categoryListViewModel = new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            };
            return View(categoryListViewModel);
        }

        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category entity = _categoryService.GetById(id.Value);

            if (entity == null)
            {
                return NotFound();
            }

            CategoryModel model = new CategoryModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
                ImageUrl = entity.ImageUrl,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(CategoryModel model)
        {
            ModelState.Remove("SubCategories");
            if (ModelState.IsValid)
            {
                Category category = _categoryService.GetById(model.Id);
                if (category == null)
                {
                    return NotFound();
                }
                category.Name = model.Name;
                category.Url = model.Url;
                category.ImageUrl = model.ImageUrl;


                _categoryService.Update(category);
                return RedirectToAction("CategoryList");
            }
            return View(model);
        }

        public IActionResult CategoryDelete(int? id)
        {
            if (id == null)
                return NotFound();
            Category category = _categoryService.GetById(id.Value);
            if (category == null)
                return NotFound();
            _categoryService.Delete(category);
            return RedirectToAction("CategoryList");
        }

        public IActionResult GetSubCategoriesByCategoryId(int id)
        {


            return View();
        }

        #endregion

        #region SUBCATEGORY İŞLEMLERİ

        [HttpGet]
        public IActionResult SubCategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubCategoryCreate(SubCategoryModel model)
        {
            ModelState.Remove("Category");
            ModelState.Remove("Filters");
            if (ModelState.IsValid)
            {
                SubCategory subCategory = new SubCategory()
                {
                    Name = model.Name,
                    Url = model.Url,
                    ImageUrl = model.ImageUrl,
                };


                _subCategoryService.Create(subCategory);
                return RedirectToAction("SubCategoryList");
            }
            return View(model);
        }

        public IActionResult SubCategoryList()
        {
            var subCategoryListViewModel = new SubCategoryListViewModel()
            {
                SubCategories = _subCategoryService.GetAll()
            };
            return View(subCategoryListViewModel);
        }

        [HttpGet]
        public IActionResult SubCategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubCategory entity = _subCategoryService.GetById(id.Value);

            if (entity == null)
            {
                return NotFound();
            }

            SubCategoryModel model = new SubCategoryModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Url = entity.Url,
                ImageUrl = entity.ImageUrl,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SubCategoryEdit(SubCategoryModel model)
        {
            ModelState.Remove("Category");
            ModelState.Remove("Filters");
            if (ModelState.IsValid)
            {
                SubCategory subCategory = _subCategoryService.GetById(model.Id);
                if (subCategory == null)
                {
                    return NotFound();
                }
                subCategory.Name = model.Name;
                subCategory.Url = model.Url;
                subCategory.ImageUrl = model.ImageUrl;


                _subCategoryService.Update(subCategory);
                return RedirectToAction("SubCategoryList");
            }
            return View(model);
        }

        public IActionResult SubCategoryDelete(int? id)
        {
            if (id == null)
                return NotFound();
            SubCategory subCategory = _subCategoryService.GetById(id.Value);
            if (subCategory == null)
                return NotFound();
            _subCategoryService.Delete(subCategory);
            return RedirectToAction("SubCategoryList");
        }


        #endregion

    }
}
