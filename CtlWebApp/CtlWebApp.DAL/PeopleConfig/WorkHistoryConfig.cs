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
    public class WorkHistoryConfig: IEntityTypeConfiguration<WorkHistory>
    {
        public void Configure(EntityTypeBuilder<WorkHistory> builder)
        {
            builder.Property(c => c.WorkPlaceName).IsUnicode().HasMaxLength(70);
            builder.Property(c => c.Jobtittle).IsUnicode().HasMaxLength(100);
            builder.Property(c => c.StartDate).IsUnicode().HasMaxLength(40);
            builder.Property(c => c.EndDate).IsUnicode().HasMaxLength(40);
            builder.Property(c => c.LastRight).IsUnicode().HasMaxLength(50);
            builder.Property(c => c.ReasonForLeavingServeices).IsUnicode().HasMaxLength(80);
        }
    }
}
