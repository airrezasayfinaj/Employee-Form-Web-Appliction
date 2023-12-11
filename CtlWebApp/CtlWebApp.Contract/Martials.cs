using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Contract
{
  public  enum Martials
    {
        [Display(Name = "مجرد")]
        Single =0,
        [Display(Name = "متعهل")]
        Maried =1
    }
}
