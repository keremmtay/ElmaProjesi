using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.BusinessLayer.Abstract
{
    public interface IFilterService
    {
        Filter GetById(int id);
        List<Filter> GetAll();
        void Create(Filter filter);
        void Update(Filter filter);
        void Delete(Filter filter);
        SubCategory GetByIdWithSubCategories(int filterId);
        void DeleteFilterFromSubCategories(int filterId, int subCategoriesId);
    }
}
