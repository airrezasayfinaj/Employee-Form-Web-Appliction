using CtlWebApp.Core.Cityes;
using CtlWebApp.Core.Common;
using CtlWebApp.Core.ICityRepository;
using CtlWebApp.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.CityConfigs
{
    public class CityRepository : BaseRepository<City>,ICityRepository
    {
        public CityRepository(EmployeeContext employeeContext) : base(employeeContext)
        {
        }
    }
}
