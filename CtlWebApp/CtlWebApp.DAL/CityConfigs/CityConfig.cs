using CtlWebApp.Core.Cityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.CityConfigs
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(40).IsUnicode();
        }
    }
}
