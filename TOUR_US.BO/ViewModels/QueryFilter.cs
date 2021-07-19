using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_US.BO.ViewModels
{
    public class QueryFilter
    {

        public QueryFilter()
        {
            PageNumber = 0;
            Range = 100;
        }

        public int Id { get; set; }
        public string id { get; set; }

        public string PropertyName { get; set; }

        public object PropertyValue { get; set; }

        public int PageNumber { get; set; }

        public int Range { get; set; }

        public bool OrderByDescending { get; set; }
    }
}
