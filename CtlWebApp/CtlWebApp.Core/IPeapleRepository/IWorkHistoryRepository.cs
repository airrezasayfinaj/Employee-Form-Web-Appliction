using CtlWebApp.Core.Common;
using CtlWebApp.Core.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Core.IPeapleRepository
{
    public interface IWorkHistoryRepository:IBaseRepository<WorkHistory>
    {
        public IQueryable<WorkHistory> GetPersonworkhistory(int personId);
    }
}
