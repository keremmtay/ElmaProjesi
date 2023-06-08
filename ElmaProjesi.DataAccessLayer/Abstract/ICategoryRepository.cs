using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        void DeleteSubCategoriesFromCategory(int subCategoriesId, int categoryId);
        Category GetByIdWithSubCategories( int categoryId);
    }
}
