using CtlWebApp.Core.Cityes;
using CtlWebApp.Core.People;
using CtlWebApp.Core.States;
using CtlWebApp.DAL.CityConfigs;
using CtlWebApp.DAL.PeopleConfig;
using CtlWebApp.DAL.StateConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.Common
{
    public class EmployeeContext:DbContext
    {
        public DbSet<City> Citys { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DbSet<WorkHistory> WorkHistory { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<State> States { get; set; }
            public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
            {

            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new EducationConfig());
            modelBuilder.ApplyConfiguration(new WorkHistoryConfig());

            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new StateConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
