using DDD_01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Infrastructure
{
    public interface IApplicationDbContext
    {
        DbSet<Course> Courses { get; set; }
    }
}
