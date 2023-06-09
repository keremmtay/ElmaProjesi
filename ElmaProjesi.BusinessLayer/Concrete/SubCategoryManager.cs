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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryRepository _subCategoryRepository;

        public SubCategoryManager(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public void Create(SubCategory subCategory)
        {
            _subCategoryRepository.Create(subCategory);
        }

        public void Delete(SubCategory subCategory)
        {
            _subCategoryRepository.Delete(subCategory);
        }

        public void DeleteFilterFromSubCategories(int filterId, int subCategoriesId)
        {
            _subCategoryRepository.DeleteFilterFromSubCategories(filterId, subCategoriesId);
        }

        public List<SubCategory> GetAll()
        {
            return _subCategoryRepository.GetAll();
        }

        public SubCategory GetById(int id)
        {
            return _subCategoryRepository.GetById(id);
        }

        public SubCategory GetByIdWithService(int subCategoryId)
        {
            return _subCategoryRepository.GetByIdWithService(subCategoryId);
        }

        public List<SubCategory> GetBySubCategoriesByCategoryUrl(string category)
        {
            return _subCategoryRepository.GetBySubCategoriesByCategoryUrl(category);
        }

        public void Update(SubCategory subCategory)
        {
            _subCategoryRepository.Update(subCategory);
        }
    }
}
