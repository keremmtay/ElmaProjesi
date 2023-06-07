using ElmaProjesi.DataAccessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Concrete
{
    public class FilterRepository : GenericRepository<Filter, ElmaContext>, IFilterRepository
    {
        public void DeleteFilterFromSubCategories(int filterId, int subCategoriesId)
        {
            throw new NotImplementedException();
        }

        public SubCategory GetByIdWithSubCategories(int filterId)
        {
            throw new NotImplementedException();
        }
    }
}

             