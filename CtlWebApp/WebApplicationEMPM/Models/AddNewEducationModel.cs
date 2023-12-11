using CtlWebApp.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEMPM.Models
{
    public class AddNewEducationModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(70)]
        [Required]
        public string city { get; set; }
        [Required]
        public int TotalAverage { get; set; }
        [Required]
        public DateTime DateReceived { get; set; }
        [StringLength(200)]
        [Required]
        public string Orientaion { get; set; }
        [StringLength(40)]
        [Required]
        public string FeildOfStudy { get; set; }
        [EnumDataType(typeof(Educatuions))]
        public Educatuions Education { get; set; }
    }
}
