using CtlWebApp.Core.IPeapleRepository;
using CtlWebApp.Core.People;
using CtlWebApp.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.PeopleConfig
{
    public class PersonRepository : BaseRepository<Person>,IPersonRepository
    {
        public PersonRepository(EmployeeContext employeeContext) : base(employeeContext)
        {
        }
    }
}
