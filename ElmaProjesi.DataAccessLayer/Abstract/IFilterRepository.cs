using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Abstract
{
    public interface IFilterRepository:IRepository<Filter>
    {
        void DeleteFilterFromSubCategories(int filterId, int subCategoriesId);
        SubCategory GetByIdWithSubCategories(int filterId);
    }
}
