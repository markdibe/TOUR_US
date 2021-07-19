using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_US.DAL.Models;
using TOUR_US.DAL.Services;

namespace TOUR_US.DAL.Repos
{
    public class ActivityRepos : GenericRepos<Activity>,IActivityRepos
    {
        public ActivityRepos(ApplicationDbContext context) : base(context)
        {
        }

    }
}
