using DDD_02.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_02.Infrastructure
{
    public abstract class UnitOfWork : IUnitOfWork
    {
        protected DbContext _dbContext;
        
        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Dispose()
        {
           _dbContext.Dispose();
        }

        public virtual void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
