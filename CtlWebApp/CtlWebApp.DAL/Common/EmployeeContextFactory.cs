using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.Common
{
    public class EmployeeContextFactory : IDesignTimeDbContextFactory<EmployeeContext>
    {
        public EmployeeContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EmployeeContext>();
            builder.UseSqlServer("Server=.;Database=CtlEmployeeWebApp;Integrated Security=True;MultipleActiveResultSets=true");
            return new EmployeeContext(builder.Options);
        }
    }
}
