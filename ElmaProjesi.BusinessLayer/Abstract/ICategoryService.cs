using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetByIdWithSubCategories(int categoryId);
        void DeleteSubCategoriesFromCategory(int subCategoriesId, int categoryId);
    }
}
