using CtlWebApp.Core.Common;
using CtlWebApp.Core.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Core.IPeapleRepository
{
    public interface IEducatioRepository:IBaseRepository<Education>
    {

        public IQueryable<Education> GetPersonEducations(int personId);
      
    }
}
