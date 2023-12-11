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
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.Property(c => c.city).IsUnicode().HasMaxLength(70);
            builder.Property(c => c.TotalAverage).IsUnicode().HasMaxLength(2);
            builder.Property(c => c.DateReceived).IsUnicode().HasMaxLength(40);
            builder.Property(c => c.Orientaion).IsUnicode().HasMaxLength(200);
            builder.Property(c => c.FeildOfStudy).IsUnicode().HasMaxLength(30);
            builder.Property(c => c.Educatuion).IsUnicode().HasMaxLength(30);
        }
    }
}
