using CtlWebApp.Core;
using CtlWebApp.Core.Common;
using CtlWebApp.Core.People;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtlWebApp.DAL.Common
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly EmployeeContext employeeContext;
        public BaseRepository(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }
        public TEntity Add(TEntity entity)
        {
            employeeContext.Set<TEntity>().Add(entity);
            employeeContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                Id = id
            };
            employeeContext.Remove(entity);
            employeeContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return employeeContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return employeeContext.Set<TEntity>().AsQueryable();
        }
        public void Edit(TEntity entity)
        {
            employeeContext.Entry(entity).State = EntityState.Modified;
            employeeContext.SaveChanges();
        }

        public Person GetByNationalCode(string nationalCode)
        {
           return employeeContext.People.Single(a => a.NationalCode == nationalCode);
        }
    }
}
