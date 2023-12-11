using CtlWebApp.Contract;
using CtlWebApp.Core.Cityes;
using CtlWebApp.Core.People;
using CtlWebApp.Core.States;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEMPM.Models
{
    public class AddNewPersonViewModel
    {
        [Required]
        [StringLength(11)]
        public string NationalCode { get; set; }
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }
        [StringLength(80)]
        [Required]
        public string BirthPlace { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [StringLength(50)]
        [Required]
        public string NameOfFather { get; set; }
        [EnumDataType(typeof(Genders))]
        public Genders gender { get; set; }
        [EnumDataType(typeof(Martials))]
        public Martials Martial { get; set; }
    }

}
