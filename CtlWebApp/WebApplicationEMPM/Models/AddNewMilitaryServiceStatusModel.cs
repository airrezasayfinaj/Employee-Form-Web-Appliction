using CtlWebApp.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEMPM.Models
{
    public class AddNewMilitaryServiceStatusModel
    {
        [Key]
        public int Id { get; set; }
        [EnumDataType(typeof(VazifeStates))]
        public VazifeStates varzifaState { get; set; }
        [Required]
        public DateTime DateOfDispatch { get; set; }
        [Required]
        public DateTime Releasedate { get; set; }
        [Required]
        public int IdentityNumber { get; set; }
    }
}
