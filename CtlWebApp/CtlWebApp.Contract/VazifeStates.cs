using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Contract
{
   public enum VazifeStates
    {
        [Display(Name = "نیاز نیست")]
        NoNedded =0,
        [Display(Name = "معافیت پزشکی")]
        MoafiyatePezeshki =1,
        [Display(Name = "معافیت کفالت")]
        moafitkefalat = 2,
        [Display(Name = "معافیت موارد خاص")]
        mofiatmavaredkhas = 3,
        [Display(Name = "معافیت خرید خدمت")]
        kharidkhedmat = 4,
        [Display(Name = "معافیت تحصیلی")]
        tahsily = 5,
        [Display(Name = "خانم هستم")]
        khan = 6
    }
}
