using CtlWebApp.Contract;
using CtlWebApp.Core.Cityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Core.People
{
  public  class Education:BaseEntity
    {
        public string city { get; set; }
        public int TotalAverage { get; set; }
        public DateTime DateReceived { get; set; }
        public string Orientaion { get; set; }
        public string FeildOfStudy { get; set; }
        public Educatuions Educatuion { get; set; }

    }
}
