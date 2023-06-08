using ElmaProjesi.BusinessLayer.Abstract;
using ElmaProjesi.DataAccessLayer.Abstract;
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
        ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }

        public void Create(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public void DeleteSubCategoriesFromCategory(int subCategoriesId, int categoryId)
        {
            _categoryRepository.DeleteSubCategoriesFromCategory(subCategoriesId, categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
          return _categoryRepository.GetById(id);
        }

        public Category GetByIdWithSubCategories(int categoryId)
        {
            return _categoryRepository.GetByIdWithSubCategories(categoryId);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
