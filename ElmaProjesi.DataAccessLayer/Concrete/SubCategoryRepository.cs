using ElmaProjesi.DataAccessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Concrete
{
    public class SubCategoryRepository : GenericRepository<SubCategory, ElmaContext>, ISubCategoryRepository
    {
        public void DeleteFilterFromSubCategories(int filterId, int subCategoriesId)
        {
            throw new NotImplementedException();
        }

        public SubCategory GetByIdWithService(int subCategoryId)
        {
            throw new NotImplementedException();
        }
        public List<SubCategory> GetBySubCategoriesByCategoryUrl(string category)
        {
            using (var context = new ElmaContext())
            {


                Category cat = context.Categories
                    .Where(y => y.Url == category)
                    .Include(x => x.SubCategories)
                    .FirstOrDefault();

                var lists = cat.SubCategories;
                return lists;
            }
        }
    }
}
