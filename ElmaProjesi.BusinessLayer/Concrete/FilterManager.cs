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
    public class FilterManager : IFilterService
    {
        IFilterRepository _filterRepository;

        public FilterManager(IFilterRepository filterRepository)
        {
            _filterRepository = filterRepository;
        }

        public void Create(Filter filter)
        {
            _filterRepository.Create(filter);
        }

        public void Delete(Filter filter)
        {
            _filterRepository.Delete(filter);
        }

        public void DeleteFilterFromSubCategories(int filterId, int subCategoriesId)
        {
            _filterRepository.DeleteFilterFromSubCategories(filterId,subCategoriesId);
        }

        public List<Filter> GetAll()
        {
            return _filterRepository.GetAll();
        }

        public Filter GetById(int id)
        {
            return _filterRepository.GetById(id);
        }

        public SubCategory GetByIdWithSubCategories(int filterId)
        {
           return _filterRepository.GetByIdWithSubCategories(filterId);
        }

        public void Update(Filter filter)
        {
            _filterRepository.Update(filter);
        }
    }
}
