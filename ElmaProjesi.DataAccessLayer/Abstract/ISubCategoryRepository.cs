using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Abstract
{
    public interface ISubCategoryRepository : IRepository<SubCategory>
    {
        void DeleteFilterFromSubCategories(int filterId, int subCategoriesId);
        SubCategory GetByIdWithService(int subCategoryId);
        List<SubCategory> GetBySubCategoriesByCategoryUrl(string category);
    }
}
