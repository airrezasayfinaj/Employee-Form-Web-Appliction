using CtlWebApp.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.PeopleConfig
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(c => c.FirstName).IsUnicode().HasMaxLength(50);
            builder.Property(c => c.LastName).IsUnicode().HasMaxLength(50);
            builder.Property(c => c.Image).IsRequired().IsUnicode(false);
            builder.Property(c => c.Email).IsUnicode().HasMaxLength(60);
            builder.Property(c => c.BirthDate).IsUnicode().IsRequired().HasMaxLength(40);
            builder.Property(c => c.BirthPlace).IsUnicode().IsRequired().HasMaxLength(80);
            builder.Property(c => c.PhoneNumber).IsUnicode().IsRequired().HasMaxLength(11);
            builder.Property(c => c.NameOfFather).IsUnicode().HasMaxLength(50);
            builder.Property(c => c.Gender).IsUnicode().IsRequired().HasMaxLength(5);
            builder.Property(c => c.MartialStatus).IsUnicode().IsRequired().HasMaxLength(8);
            builder.Property(c => c.Address).IsUnicode().IsRequired().HasMaxLength(100);
            builder.Property(c => c.DateOfDispatch).IsUnicode().HasMaxLength(40);
            builder.Property(c => c.NationalCode).IsRequired().HasMaxLength(11);
            builder.Property(c => c.IdentityNumber).IsUnicode().IsRequired().HasMaxLength(10);
            builder.Property(c => c.Releasedate).IsUnicode().HasMaxLength(40);
            builder.Property(c => c.VerficationCode).IsUnicode().HasMaxLength(10);
            builder.Property(c => c.Acceptenc).IsUnicode().HasMaxLength(5);
            builder.Property(c => c.Avenue).IsUnicode().HasMaxLength(50);
            builder.Property(c => c.Number).IsUnicode().HasMaxLength(7);
            builder.Property(c => c.Street).IsUnicode().HasMaxLength(70);
            builder.Property(c => c.Skill).IsUnicode().HasMaxLength(200);
        }
    }
}
