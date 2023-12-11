using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Core.People
{
  public  class WorkHistory:BaseEntity
    {
        public string WorkPlaceName { get; set; }
        public string Jobtittle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long LastRight { get; set; }
        public string ReasonForLeavingServeices { get; set; }

    }
}
