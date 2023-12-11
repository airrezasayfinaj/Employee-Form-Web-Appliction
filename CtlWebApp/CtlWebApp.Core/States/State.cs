using CtlWebApp.Core.Cityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Core.States
{
    public class State : BaseEntity
    {
        public List<City> City { get; set; }
        public string Name { get; set; }
    }
}
