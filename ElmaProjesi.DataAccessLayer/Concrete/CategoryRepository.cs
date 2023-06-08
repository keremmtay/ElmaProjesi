using ElmaProjesi.DataAccessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Concrete
{
    public class CategoryRepository : GenericRepository<Category, ElmaContext>, ICategoryRepository
    {
        public void DeleteSubCategoriesFromCategory(int subCategoriesId, int categoryId)
        {
            throw new NotImplementedException();
        }

        public Category GetByIdWithSubCategories(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
