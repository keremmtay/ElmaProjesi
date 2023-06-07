using ElmaProjesi.BusinessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void Create(Category category)
        {
            _categoryService.Create(category);
        }

        public void Delete(Category category)
        {
            _categoryService.Delete(category);
        }

        public void DeleteSubCategoriesFromCategory(int subCategoriesId, int categoryId)
        {
            _categoryService.DeleteSubCategoriesFromCategory(subCategoriesId, categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        public Category GetById(int id)
        {
          return _categoryService.GetById(id);
        }

        public Category GetByIdWithSubCategories(int categoryId)
        {
            return _categoryService.GetByIdWithSubCategories(categoryId);
        }

        public void Update(Category category)
        {
            _categoryService.Update(category);
        }
    }
}
