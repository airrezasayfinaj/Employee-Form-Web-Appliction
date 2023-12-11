using CtlWebApp.Core.IPeapleRepository;
using CtlWebApp.Core.People;
using CtlWebApp.DAL.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.PeopleConfig
{
    public class EducationRepository : BaseRepository<Education>,IEducatioRepository
    {
        public EducationRepository(EmployeeContext employeeContext) : base(employeeContext)
        {
        }

        public IQueryable<Education> GetPersonEducations(int personId)
        {
            
                return employeeContext.Set<Person>().Include(a=>a.educationsHistory).Single(a=>a.Id==personId).educationsHistory.AsQueryable();
            
        }
    }
}
