using ElmaProjesi.BusinessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.BusinessLayer.Concrete
{
    public class FilterManager : IFilterService
    {
        IFilterService _filterService;

        public FilterManager(IFilterService filterService)
        {
            _filterService = filterService;
        }

        public void Create(Filter filter)
        {
            _filterService.Create(filter);
        }

        public void Delete(Filter filter)
        {
            _filterService.Delete(filter);
        }

        public void DeleteFilterFromSubCategories(int filterId, int subCategoriesId)
        {
            _filterService.DeleteFilterFromSubCategories(filterId,subCategoriesId);
        }

        public List<Filter> GetAll()
        {
            return _filterService.GetAll();
        }

        public Filter GetById(int id)
        {
            return _filterService.GetById(id);
        }

        public SubCategory GetByIdWithSubCategories(int filterId)
        {
           return _filterService.GetByIdWithSubCategories(filterId);
        }

        public void Update(Filter filter)
        {
            _filterService.Update(filter);
        }
    }
}
