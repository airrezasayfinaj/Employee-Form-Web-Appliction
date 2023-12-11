using CtlWebApp.Core.IStateRepositorys;
using CtlWebApp.Core.States;
using CtlWebApp.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.StateConfigs
{
    public class StateRepository : BaseRepository<State>,IStateRepository
    {
        public StateRepository(EmployeeContext employeeContext) : base(employeeContext)
        {
        }
    }
}
