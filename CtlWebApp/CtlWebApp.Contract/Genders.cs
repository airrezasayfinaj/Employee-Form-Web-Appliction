using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Contract
{
   public enum Genders
    {
        [Display(Name = "مرد")]
        Maile =0,
        [Display(Name = "زن")]
        Femail =1
    }
}
