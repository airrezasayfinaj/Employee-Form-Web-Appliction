using CtlWebApp.Contract;
using CtlWebApp.Core.Cityes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.Core.People
{
    public class Person : BaseEntity
    {
        public string NationalCode { get; set; }
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Image { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int PhoneNumber { get; set; }
        public string NameOfFather { get; set; }
        public Genders Gender { get; set; }
        public Martials MartialStatus { get; set; }
        public DateTime DateOfDispatch { get; set; }
        public VazifeStates VazifeState { get; set; }
        public DateTime Releasedate { get; set; }
        public bool Acceptenc { get; set; }
        public string Skill { get; set; }
        public string VerficationCode { get; set; }
        public string Address { get; set; }
        public string Avenue { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public virtual ICollection<Education> educationsHistory { get; set; } = new HashSet<Education>();
        public virtual ICollection<WorkHistory> workHistories { get; set; } = new HashSet<WorkHistory>();
    }
}
