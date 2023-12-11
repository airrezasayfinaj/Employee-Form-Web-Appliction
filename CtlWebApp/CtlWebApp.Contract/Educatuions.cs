using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Contract
{
    public enum Educatuions
    {
        [Display(Name = "دیپلم")]
        diplom =0,
        [Display(Name = "سیکل")]
        sikl = 1,
        [Display(Name = "پیش دانشگاهی")]
        pishdanesh = 2,
        [Display(Name = "فوق دیپلم")]
        fogdip = 3,
        [Display(Name = "لیسانس")]
        lisans = 4,
        [Display(Name = "فوق لیسانس")]
        foglisans = 5,
        [Display(Name = "دکترا")]
        doktora = 6
    }
}
