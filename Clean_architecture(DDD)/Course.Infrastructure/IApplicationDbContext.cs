using Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Infrastructure
{
   public interface IApplicationDbContext
    {
        public DbSet<Courses> Course { get; set; }
    }
}
