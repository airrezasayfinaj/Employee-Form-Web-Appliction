using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEMPM.Models
{
    public class AddNewAddressInfoModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(70)]
        [Required]
        public string Street { get; set; }
        [StringLength(7)]
        [Required]
        public string Number { get; set; }
        [StringLength(50)]
        [Required]
        public string Avenue { get; set; }
        [StringLength(200)]
        [Required]
        public string Address { get; set; }
    }
}
