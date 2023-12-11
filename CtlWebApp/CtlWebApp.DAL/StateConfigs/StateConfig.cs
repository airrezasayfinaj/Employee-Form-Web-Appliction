using CtlWebApp.Core.States;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.StateConfigs
{
    public class StateConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.Property(c => c.Name).IsRequired().IsUnicode().HasMaxLength(40);
        }
    }
}
