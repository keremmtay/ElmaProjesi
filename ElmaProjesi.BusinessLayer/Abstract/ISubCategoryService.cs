using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.BusinessLayer.Abstract
{
    public interface ISubCategoryService
    {
        SubCategory GetById(int id);
        List<SubCategory> GetAll();
        void Create(SubCategory subCategory);
        void Update(SubCategory subCategory);
        void Delete(SubCategory subCategory);
        SubCategory GetByIdWithService(int subCategoryId);
        void DeleteFilterFromSubCategories(int filterId, int subCategoriesId);
        List<SubCategory> GetBySubCategoriesByCategoryUrl(string category);
    }
}
