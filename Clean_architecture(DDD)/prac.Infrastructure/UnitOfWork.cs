using Microsoft.EntityFrameworkCore;
using prac.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Infrastructure
{
    public abstract class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _dbContext;

        protected UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual void Dispose()
        {
            _dbContext?.Dispose();
        }

        public void Save()
        {
            _dbContext?.SaveChanges();
        }
    }
}
