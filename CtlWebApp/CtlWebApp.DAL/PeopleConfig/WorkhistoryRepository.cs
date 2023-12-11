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
    public class WorkhistoryRepository : BaseRepository<WorkHistory>,IWorkHistoryRepository
    {
        public WorkhistoryRepository(EmployeeContext employeeContext) : base(employeeContext)
        {
        }


        public IQueryable<WorkHistory> GetPersonworkhistory(int personId)
        {
            return employeeContext.Set<Person>().Include(a => a.workHistories).Single(a => a.Id == personId).workHistories.AsQueryable();
        }
    }
}
