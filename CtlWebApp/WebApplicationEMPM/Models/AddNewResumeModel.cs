using CtlWebApp.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEMPM.Models
{
    public class AddNewResumeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkPlaceName { get; set; }
        [Required]
        public bool Acceptenc { get; set; }
        [StringLength(10)]
        [Required]
        public string VerficationCode { get; set; }
        [StringLength(200)]
        [Required]
        public string Skill { get; set; }
        [StringLength(80)]
        [Required]
        public string Jobtittle { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public long LastRight { get; set; }
        [StringLength(150)]
        [Required]
        public string ReasonForLeavingServeices { get; set; }
 
    }
}
