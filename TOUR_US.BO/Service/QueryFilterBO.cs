using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_US.BO.ViewModels;
using TOUR_US.DAL;
using TOUR_US.DAL.Models;
using TOUR_US.DAL.Services;
using System.Linq.Dynamic.Core;

namespace TOUR_US.BO.Service
{
    public class QueryFilterBO<T> : BaseBO where T : class
    {
        private readonly IGenericRepos<T> _generic;
        public QueryFilterBO(IUnitOfWork unit, IGenericRepos<T> generic) : base(unit)
        {
            _generic = generic;
        }

        public IQueryable<T> Filter(QueryFilter filter)
        {
            var result = _generic.GetAll();
            if (!string.IsNullOrEmpty(filter.PropertyName) && filter.PropertyValue != null)
            {
                result = result.Where(x => x.GetType().GetProperty(filter.PropertyName).GetValue(x, null).ToString() == filter.PropertyValue.ToString());
            }
            result = result.Where(string.Format("{0}=={1}", filter.PropertyName, filter.PropertyValue));
            return result;

        }
    }
}
