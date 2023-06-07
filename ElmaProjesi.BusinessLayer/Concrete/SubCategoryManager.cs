using ElmaProjesi.BusinessLayer.Abstract;
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
        ISubCategoryService _subCategoryService;

        public SubCategoryManager(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        public void Create(SubCategory subCategory)
        {
           _subCategoryService.Create(subCategory);
        }

        public void Delete(SubCategory subCategory)
        {
           _subCategoryService.Delete(subCategory);
        }

        public void DeleteServiceFromSubCategories(int serviceId, int subCategoriesId)
        {
            _subCategoryService.DeleteServiceFromSubCategories(serviceId,subCategoriesId);
        }

        public List<SubCategory> GetAll()
        {
           return _subCategoryService.GetAll();
        }

        public SubCategory GetById(int id)
        {
           return _subCategoryService.GetById(id);
        }

        public SubCategory GetByIdWithService(int subCategoryId)
        {
            return _subCategoryService.GetByIdWithService(subCategoryId);
        }

        public void Update(SubCategory subCategory)
        {
            _subCategoryService.Update(subCategory);
        }
    }
}
